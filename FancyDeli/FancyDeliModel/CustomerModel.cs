namespace FancyDeliModel
{
    public class CustomerModel
    {
        // this is a field 
        private int _CustomerId;
        //This is a property
        public int customerID
        {
            get { return _CustomerId; }
            set
            {
                if (value > 0)
                {
                    _CustomerId = value;
                }
                else
                {
                    Console.WriteLine("Customer ID can only hold positive numbers!");
                }
            }
        }
        public List<CustomerInfo> Customers { get; set;}
        
        public string CustomerName { get; set; }

        public CustomerModel()
        {
           _CustomerId = 1;
           CustomerName = "Moustapha";
           Customers = new List<CustomerInfo>();
        }
        

       
        
    }
}
    
