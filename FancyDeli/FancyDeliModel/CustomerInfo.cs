 namespace FancyDeliModel
 {
     public class CustomerInfo
     {
         // This property represent the list of customer information
         public string Name { get; set; }
         public string Address { get; set; }
         public string Email { get; set; }
         public string ListOfOrders { get; set; }
         private int _PhoneNumber;
         public int PhoneNumber
         {
             get { return _PhoneNumber; }
             set 
            {
                if (value >=0)
                {
                    _PhoneNumber = value;
                } 
                else
                {
                    Console.WriteLine("Phone number cannot be negative!");
                }
            }
        }
        
    } 
      
}