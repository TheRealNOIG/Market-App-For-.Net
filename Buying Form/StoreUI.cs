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

        private void setup()
        {
            client.startClient();
            SetupVendorsAndItems();
            store.ArrangeItemsAlphabetically();
            this.Invoke((MethodInvoker)delegate () {
                showListOfItems();
                killLoadingForm();
            });
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
            store.Vendors = client.getVenderList();
            store.Items = client.getItemList(store.Vendors);
        }

        Form formy;
        private void makeLoadingForm()
        {
            this.panel1.Enabled = false;
            formy = new Form();
            formy.Width = 200;
            formy.Height = 25;
            formy.StartPosition = FormStartPosition.CenterScreen;
            formy.FormBorderStyle = FormBorderStyle.None;
            formy.BackColor = Color.White;
            formy.TopMost = true;

            Label label = new Label();
            label.Font = new System.Drawing.Font("Arial Black", 10f, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label.Location = new Point(5, 5);
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
            this.Invoke((MethodInvoker)delegate () {
                this.panel1.Enabled = false;
                makeLoadingForm();
            });
            store.Vendors.Clear();
            store.Items.Clear();
            SetupVendorsAndItems();
            store.ArrangeItemsAlphabetically();
            showListOfItems();
            this.Invoke((MethodInvoker)delegate () {
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
            new Thread(new ThreadStart(this.refreshForm)).Start();
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
    }
}
