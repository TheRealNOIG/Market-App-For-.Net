using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net.Sockets;
using System.Net;
using TylerGregorcyksLibrary.Main;
using MySql.Data.MySqlClient;

namespace Server
{
    class Program
    {
        private static int bufferSize = 2048;
        private static byte[] buffer = new byte[bufferSize];
        private static List<Socket> clientSockets = new List<Socket>();
        private static Socket serverSocket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);


        static void Main(string[] args)
        {
            Console.Title = "Server";
            SetupServer();
            Console.ReadKey();
            CloseAllSockets();
        }

        private static void SetupServer()
        {
            Console.WriteLine("Settings Up Server Plz Wait");
            serverSocket.Bind(new IPEndPoint(IPAddress.Any, 69));
            serverSocket.Listen(10);
            serverSocket.BeginAccept(new AsyncCallback(CallBack), null);
            Console.WriteLine("Server Made");
        }

        private static void CallBack(IAsyncResult e)
        {
            try
            {
                Socket socket = serverSocket.EndAccept(e);
                clientSockets.Add(socket);
                Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt") + ": " + "Client Connected");
                socket.BeginReceive(buffer, 0, buffer.Length, SocketFlags.None, new AsyncCallback(ReceiveCallBack), socket);
                serverSocket.BeginAccept(new AsyncCallback(CallBack), null);
            }
            catch (Exception ex) { Console.WriteLine(ex.Message); }
        }

        private static void ReceiveCallBack(IAsyncResult e)
        {
            try
            {
                Socket socket = (Socket)e.AsyncState;
                int received;
                try
                {
                    received = socket.EndReceive(e);
                }
                catch (SocketException)
                {
                    Console.WriteLine("Client forcefully disconnected");
                    socket.Close();
                    clientSockets.Remove(socket);
                    return;
                }
                byte[] dataBuf = new byte[received];
                Array.Copy(buffer, dataBuf, received);

                string connString = "server=localhost;user=root;database=testing;port=3306;password=PASSWORD;";
                MySqlConnection conn = new MySqlConnection(connString);
                MySqlCommand mySQLCommand = conn.CreateCommand();

                string text = Encoding.ASCII.GetString(dataBuf);
                Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt") + ": " + "Client request: " + text);

                string response = string.Empty;
                string command = StringFunctions.SplitStringBeforeFirstDelimiter(text, ':');

                try
                {
                    conn.Open();
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                //IF THE REC
                try
                {
                    if (command.ToLower() == "mysql")
                    {
                        string sendCommand = StringFunctions.SplitStringAfterLastDelimiter(text, ':');
                        response = MySQLCommands(sendCommand, mySQLCommand);
                    }
                    else if (command.ToLower() == "mysqllist")
                    {
                        string commandsWithoutMySQL = StringFunctions.SplitStringAfterLastDelimiter(text, ':');
                        string[] commands = StringFunctions.SplitString(commandsWithoutMySQL, ';');
                        foreach (string sendCommand in commands)
                        {
                            if (!string.IsNullOrEmpty(sendCommand))
                            {
                                response += MySQLCommands(sendCommand, mySQLCommand) + ";";
                                response = RemoveInvaledFromString(response, ';');
                            }
                        }
                    }
                    else
                    {
                        response = "Invaled";
                    }
                }
                catch (Exception et) { Console.WriteLine(et.Message); socket.Close(); clientSockets.Remove(socket); }
                

                if(response == string.Empty)
                {
                    response = "Invaled";
                }

                if (response != string.Empty)
                {
                    Console.WriteLine(DateTime.Now.ToString("h:mm:ss tt") + ": " + "Sent To Client: " + response);
                    byte[] data = Encoding.ASCII.GetBytes(response);
                    socket.Send(data);
                    serverSocket.BeginAccept(new AsyncCallback(CallBack), null);
                }

                conn.Close();
                socket.BeginReceive(buffer, 0, bufferSize, SocketFlags.None, ReceiveCallBack, socket);
            }
            catch (Exception) { }
        }

        private static void CloseAllSockets()
        {
            foreach (Socket socket in clientSockets)
            {
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }

            serverSocket.Close();
        }


        private static string MySQLCommands(string text, MySqlCommand mySQLCommand)
        {
            MySqlDataReader reader;
            string response = "Invaled";
            string command = text;
            if(StringFunctions.SplitStringBeforeFirstDelimiter(text, '.') != null)
            {
                command = StringFunctions.SplitStringBeforeFirstDelimiter(text, '.');
            }
            else { command = text; }
            if (command.ToLower() == "getvendorbyid")
            {
                if (StringFunctions.SplitStringAfterLastDelimiter(text, '.') != string.Empty)
                {
                    string commandtext = string.Format("SELECT * FROM vendors WHERE vendor_id={0};", StringFunctions.SplitStringAfterLastDelimiter(text, '.'));
                    mySQLCommand.CommandText = commandtext;
                    reader = mySQLCommand.ExecuteReader();
                    while (reader.Read())
                    {
                        response = string.Format("{0}:{1}:{2}:{3}:{4}:{5}:{6}:", reader.GetString(0), reader.GetString(1),
                                                                             reader.GetString(2), reader.GetString(3),
                                                                             reader.GetString(4), StringFunctions.SplitStringBeforeFirstDelimiter(reader.GetString(5), ':').Replace(" 12", "")
,
                                                                             reader.GetString(6));
                    }
                    reader.Close();
                }
            }
            else if (command.ToLower() == "getvendorcount")
            {
                mySQLCommand.CommandText = "SELECT vendor_id FROM vendors ORDER BY vendor_id DESC LIMIT 1;";
                reader = mySQLCommand.ExecuteReader();
                while (reader.Read())
                {
                    response = reader.GetString(0);
                }
                reader.Close();
            }
            else if (command.ToLower() == "getitemcount")
            {
                mySQLCommand.CommandText = "SELECT item_id FROM items ORDER BY item_id DESC LIMIT 1;";
                reader = mySQLCommand.ExecuteReader();
                while (reader.Read())
                {
                    response = reader.GetString(0);
                }
                reader.Close();
            }
            else if (command.ToLower() == "getitembyid")
            {
                string commandtext = string.Format("SELECT * FROM items WHERE item_id={0};", StringFunctions.SplitStringAfterLastDelimiter(text, '.'));
                mySQLCommand.CommandText = commandtext;
                reader = mySQLCommand.ExecuteReader();
                while (reader.Read())
                {
                    response = string.Format("{0}:{1}:{2}:{3}:{4}:{5}:{6}:", reader.GetString(0), reader.GetString(1),
                                                                         reader.GetString(2), reader.GetString(3),
                                                                         reader.GetString(4), reader.GetString(5),
                                                                         reader.GetString(6));
                }
                reader.Close();
            }
            return response;
        }

        private static string RemoveInvaledFromString(string source, char delimiter)
        {
            string response = "";
            string[] strings = StringFunctions.SplitString(source, delimiter);
            foreach(string e in strings)
            {
                if (e.ToLower() != "invaled" || string.IsNullOrWhiteSpace(e))
                {
                    response += e +";";
                }
            }
            return response;
        }
    }
}
