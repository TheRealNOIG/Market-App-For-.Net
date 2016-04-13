
namespace StoreLibrary
{
    public class Item
    {

        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int AmountOfRequestsForItem { get; set; }
        public float Amount { get; set;  }
        public Vendor Owner { get; set; }

        public string DisplayNamePrice
        {
            get
            {
                if (Amount > 1)
                    return string.Format("{0} - ${1} - {2}", Name, Price, Amount);
                else
                    return string.Format("{0} - ${1}", Name, Price);
            }
        }
    }
}
