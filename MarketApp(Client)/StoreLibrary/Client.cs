using System;
using System.Collections.Generic;
using TylerGregorcyksLibrary.Main;
using System.Net.Sockets;

namespace StoreLibrary
{
    public class Client
    {
        public SimpleClient client = new SimpleClient();

        public Client()
        { }

        public void startClient()
        {
            client.startClient("SERVERIP", 69);
        }

        public List<Vendor> getVenderList()
        {
            List<Vendor> vendorsList = new List<Vendor>();
            int vendorCount = 0;
            try { vendorCount = Int32.Parse(client.sendAndReceiveMessage("mysql:getvendorcount")); } catch { client.connected = false; return null; }
            string sendCommand = "mysqllist:";
            for (int i = 1; i <= vendorCount; i++)
            {
                sendCommand += "getvendorbyid." + i + ";";
            }
            string receive = string.Empty;
            try { receive = client.sendAndReceiveMessage(sendCommand); } catch  {  }
            string[] received = StringFunctions.SplitString(receive, ';');
            try
            {
                foreach (string info in received)
                {
                    if (!string.IsNullOrEmpty(info))
                    {
                        vendorsList.Add(new Vendor
                        {
                            FirstName = StringFunctions.SplitStringFromIndex(info, ':', 0),
                            LastName = StringFunctions.SplitStringFromIndex(info, ':', 1),
                            Email = StringFunctions.SplitStringFromIndex(info, ':', 2),
                            ItemsSold = Int32.Parse(StringFunctions.SplitStringFromIndex(info, ':', 3)),
                            Location = StringFunctions.SplitStringFromIndex(info, ':', 4),
                            DateJoined = StringFunctions.SplitStringFromIndex(info, ':', 5),
                            ID = Int32.Parse(StringFunctions.SplitStringFromIndex(info, ':', 6))
                        });
                    }
                }
            } catch { }
            return vendorsList;
        }

        public List<Item> getItemList(List<Vendor> vendorList)
        {
            List<Item> itemList = new List<Item>();
            int itemCount = 0;
            try { itemCount = Int32.Parse(client.sendAndReceiveMessage("mysql:getitemcount")); } catch  { client.connected = false; return null; }
            string sendCommand = "mysqllist:";
            for (int i = 1; i <= itemCount; i++)
            {
                sendCommand += "getitembyid." + i + ";";
            }
            string receive = string.Empty;
            try { receive = client.sendAndReceiveMessage(sendCommand); } catch {  }
            string[] received = StringFunctions.SplitString(receive, ';');
            Vendor owner = new Vendor();
            try {
                foreach (string info in received)
                {
                    if (!string.IsNullOrEmpty(info))
                    {
                        foreach (Vendor vendor in vendorList)
                        {
                            try
                            {
                                if (vendor.ID == Int32.Parse(StringFunctions.SplitStringFromIndex(info, ':', 5)))
                                {
                                    owner = vendor;
                                }
                            }
                            catch { }
                        }
                        itemList.Add(new Item
                        {
                            Name = StringFunctions.SplitStringFromIndex(info, ':', 0),
                            Description = StringFunctions.SplitStringFromIndex(info, ':', 1),
                            Price = decimal.Parse(StringFunctions.SplitStringFromIndex(info, ':', 2)),
                            Amount = float.Parse(StringFunctions.SplitStringFromIndex(info, ':', 3)),
                            AmountOfRequestsForItem = int.Parse(StringFunctions.SplitStringFromIndex(info, ':', 4)),
                            Owner = owner
                        });
                    }
                }
            } catch { }
            return itemList;
        }

    }
}
