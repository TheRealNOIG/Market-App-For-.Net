using System;
using System.Windows.Forms;
using StoreLibrary;

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
                Description = "Get High As FUUUUCKK with this shit",
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
    }
}
