namespace OrdersModel
{
    public class Orders
    {
        //Represente the list of line Items
        public string ListOfLineItem { get; set; }

        // this property represente different stores locations
        public string StoreFrontAddress { get; set; }
        public int TotalPrice { get; set; }
    }
}