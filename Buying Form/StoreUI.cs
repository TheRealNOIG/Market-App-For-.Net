using System;
using System.Windows.Forms;
using StoreLibrary;
using System.Drawing;
using System.Threading;

namespace Buying_Form
{
    public partial class ShopGUI : Form
    {

        Store store = new Store();
        BindingSource itemsBinding = new BindingSource();
        Client client = new Client();

        public ShopGUI()
        {
            InitializeComponent();
            makeLoadingForm();
            Thread setupThread = new Thread(this.setup); setupThread.IsBackground = true; setupThread.Start();
        }

        Form cantConnectForm;
        private void setup()
        {
            if (client.client.connected)
                client.client.connected = false;
            client.startClient();
            if (!client.client.connected)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    cantConnectForm = new Form();
                    System.Windows.Forms.Label label1;
                    System.Windows.Forms.Button retryButton;
                    label1 = new System.Windows.Forms.Label();
                    retryButton = new System.Windows.Forms.Button();
                    // 
                    // label1
                    // 
                    label1.AutoSize = true;
                    label1.Location = new System.Drawing.Point(13, 13);
                    label1.Name = "label1";
                    label1.Size = new System.Drawing.Size(262, 13);
                    label1.TabIndex = 0;
                    label1.Text = "Can\'t Connect To Server Please Try Again in a Minute";
                    // 
                    // retryButton
                    // 
                    retryButton.Location = new System.Drawing.Point(102, 38);
                    retryButton.Name = "retryButton";
                    retryButton.Size = new System.Drawing.Size(75, 23);
                    retryButton.TabIndex = 1;
                    retryButton.Text = "Retry";
                    retryButton.UseVisualStyleBackColor = true;
                    retryButton.Click += new System.EventHandler(failedConnectionRefreshButton_Click);
                    //
                    //cantConnecttForm
                    //
                    cantConnectForm.ClientSize = new System.Drawing.Size(294, 73);
                    cantConnectForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                    cantConnectForm.StartPosition = FormStartPosition.CenterScreen;
                    cantConnectForm.Controls.Add(retryButton);
                    cantConnectForm.Controls.Add(label1);
                    cantConnectForm.Name = "Cant Connect Form";
                    cantConnectForm.Text = "ERROR: Failed to Connect to Server";
                    cantConnectForm.Show();
                    cantConnectForm.Owner = formy;
                });
            }
            else
            {
                SetupVendorsAndItems();
                store.ArrangeItemsAlphabetically();
                this.Invoke((MethodInvoker)delegate ()
                {
                    showListOfItems();
                    killLoadingForm();
                });
            }
            Thread.CurrentThread.Abort();
        }

        private void showListOfItems() {
            itemsBinding.DataSource = store.Items;
            itemListBox.DataSource = itemsBinding;

            itemListBox.DisplayMember = "DisplayNamePrice";
            itemListBox.ValueMember = "DisplayNamePrice";
        }

        private void SetupVendorsAndItems()
        {
            if (client.client.connected)
                store.Vendors = client.getVenderList();
            else
                setup();
            if (client.client.connected)
                store.Items = client.getItemList(store.Vendors);
            else
                setup();
        }

        Form formy;
        private void makeLoadingForm()
        {
            this.panel1.Enabled = false;
            formy = new Form();
            formy.StartPosition = FormStartPosition.CenterScreen;
            formy.FormBorderStyle = FormBorderStyle.None;
            formy.Size = new Size(200, 1);
            formy.BackColor = Color.White;
            formy.Owner = this;

            Label label = new Label();
            label.Font = new System.Drawing.Font("Arial Black", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new Point(10, 5);
            label.Size = new Size(500, 75);
            label.Text = "Loading Please Wait...";
            formy.Controls.Add(label);
            formy.Show();
        }
        private void killLoadingForm()
        {
            formy.Close();
            this.panel1.Enabled = true;
        }

        private void refreshForm()
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                this.panel1.Enabled = false;
                makeLoadingForm();
            });
            if(store.Vendors != null)
                store.Vendors.Clear();
            if(store.Items != null)
                store.Items.Clear();
            SetupVendorsAndItems();
            store.ArrangeItemsAlphabetically();
            showListOfItems();
            this.Invoke((MethodInvoker)delegate ()
            {
                this.panel1.Enabled = true;
                killLoadingForm();
            });
            Thread.CurrentThread.Abort();
        }

        private void infoBox_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            e.DrawFocusRectangle();
            e.Graphics.DrawString(infoBox.Items[e.Index].ToString(), e.Font, new SolidBrush(e.ForeColor), e.Bounds);
        }

        private void infoBox_MeasureItem(object sender, MeasureItemEventArgs e)
        {
            e.ItemHeight = (int)e.Graphics.MeasureString(infoBox.Items[e.Index].ToString(), infoBox.Font, infoBox.Width).Height;
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
           Thread refreshThread = new Thread(this.refreshForm); refreshThread.IsBackground = true; refreshThread.Start();
        }

        private void itemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Need to populate the info window with all the info of the item
            Item selectedItem = (Item)itemListBox.SelectedItem;
            infoBox.Items.Clear();
            infoBox.Items.Add("Name: " + selectedItem.Name);
            infoBox.Items.Add("Desciption: " + selectedItem.Description);
            infoBox.Items.Add("Price: $" + selectedItem.Price);
            infoBox.Items.Add("Amount: " + selectedItem.Amount);
            infoBox.Items.Add("Seller: " + selectedItem.Owner.FirstName + " " + selectedItem.Owner.LastName);
            infoBox.Items.Add("Number Of Others Trying To Buy This Product: " + selectedItem.AmountOfRequestsForItem);
        }

        private void failedConnectionRefreshButton_Click(object sender, EventArgs e)
        {
            killLoadingForm();
            Thread refreshThread = new Thread(this.refreshForm); refreshThread.IsBackground = true; refreshThread.Start();
            if (cantConnectForm.Visible)
            {
                cantConnectForm.Close();
            }
        }
    }
}
