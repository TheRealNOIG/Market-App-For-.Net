using System;
using System.Windows.Forms;
using StoreLibrary;
using System.Drawing;

namespace Buying_Form
{
    public partial class ShopGUI : Form
    {

        Store store = new Store();
        BindingSource itemsBinding = new BindingSource();

        public ShopGUI()
        {
            InitializeComponent();
            SetupVoid();
            store.ArrangeItemsAlphabetically();
            showListOfItems();
        }

        void showListOfItems() {
            itemsBinding.DataSource = store.Items;
            itemListBox.DataSource = itemsBinding;

            itemListBox.DisplayMember = "DisplayNamePrice";
            itemListBox.ValueMember = "DisplayNamePrice";
        }

        private void SetupVoid()
        {
            store.Vendors.Add(new Vendor { FirstName = "Tyler", LastName = "Gregorcyk", Email = "tyler.gregorcyk@gmail.com", ItemsSold = 99, Location = "North Austin", ID = 1998 });
            store.Vendors.Add(new Vendor { FirstName = "Barack ", LastName = "Obama", Email = "therealnoig@gmail.com", ItemsSold = -2, Location = "Your Moms", ID = 1 });

            store.Items.Add(new Item
            {
                Name = "GRad",
                Description = "Some gooooood GRad",
                Price = 3.50f,
                AmountOfRequestsForItem = 0,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Name = "OG Kush",
                Description = "Get High As FUUUUCKK with this shit BOOOOOOOOOOOOOOOOOOOOYYYY",
                Price = 17.99f,
                AmountOfRequestsForItem = 78,
                Owner = store.Vendors[1]
            });
            store.Items.Add(new Item
            {
                Name = "Balls",
                Description = "2 Big Balls",
                Price = 198.21f,
                AmountOfRequestsForItem = -5,
                Owner = store.Vendors[0]
            });
            store.Items.Add(new Item
            {
                Name = "First Laddy",
                Description = "Old but still perky",
                Price = 29f,
                AmountOfRequestsForItem = 1,
                Owner = store.Vendors[1]
            });
        }

        private void itemListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Need to populate the info window with all the info of the item
            Item selectedItem = (Item)itemListBox.SelectedItem;
            infoBox.Items.Clear();
            infoBox.Items.Add("Name: " + selectedItem.Name);
            infoBox.Items.Add("Desciption: " + selectedItem.Description);
            infoBox.Items.Add("Price: $" + selectedItem.Price);
            infoBox.Items.Add("Seller: " + selectedItem.Owner);
            infoBox.Items.Add("Number of others trying to buy this product " + selectedItem.AmountOfRequestsForItem);
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
    }
}
