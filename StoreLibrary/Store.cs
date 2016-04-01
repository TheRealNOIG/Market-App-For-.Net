using System.Collections.Generic;
using System.Linq;
using TylerGregorcyksLibrary.Main;

namespace StoreLibrary
{
    public class Store
    {

        public List<Vendor> Vendors { get; set; }
        public List<Item> Items { get; set; }

        public Store()
        {
            Vendors = new List<Vendor>();
            Items = new List<Item>();
        }

        public void ArrangeItemsAlphabetically() {
            List<Item> tmp = Items.ToList();
            string listOfItemNames = "";
            foreach (Item item in tmp)
            {
                listOfItemNames += item.Name + ";";
            }
            string[] finalList = StringFunctions.SplitStringAlphabetically(listOfItemNames, ';');
            Items.Clear();
            foreach (string name in finalList)
            {
                foreach (Item item in tmp)
                {
                    if (item.Name == name)
                        Items.Add(item);
                }
            }
        }
    }
}
