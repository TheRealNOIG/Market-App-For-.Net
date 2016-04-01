
namespace StoreLibrary
{
    public class Item
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int AmountOfRequestsForItem { get; set; }
        public Vendor Owner { get; set; }

        public string DisplayNamePrice
        {
            get
            {
                return string.Format("{0} - {1}", Name, Price);
            }
        }
    }
}
