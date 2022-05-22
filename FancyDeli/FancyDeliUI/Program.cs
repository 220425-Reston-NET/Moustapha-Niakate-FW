//See https://aka.ms/new-console-template for more information

using FancyDeliModel;
using FancyDeliUI;
// using FancyDeliModel;

//  Console.WriteLine("Hello, World!");

// //Creating an object
//   CustomerModel customer = new CustomerModel();
//   customer.customerID = 100;
//   Console.WriteLine(customer.customerID);

// //Adding customer infos to obj
//  CustomerInfo Name = new CustomerInfo();
//  CustomerInfo.Name = "Moustapha";
//  CustomerInfo info2 = new CustomerInfo();
//  info2.Address = 
//  CustomerInfo info3 = new CustomerInfo();
//  info3.Email =
//  CustomerInfo info4 = new CustomerInfo();
//  info4.ListOfOrders =
//  CustomerInfo info5 = new CustomerInfo();
//  info5.PhoneNumber = 



//  customerObj.customerInfos.Add(info1);
//  customerObj.customerInfos.Add(info2);
//  customerObj.customerInfos.Add(info3);
//  customerObj.customerInfos.Add(info4);
//  customerObj.customerInfos.Add(info5);

//  //display everything that the customer obj currently has in it ability
//  foreach (CustomerInfo item in customerObj.customerInfos)
//   {
//       Console.WriteLine(item.Name);
//   }
//  Console.Clear();


//creating MainMenu obj
IMenu menu = new MainMenu();
bool repeat = true;

while (repeat)
{
    Console.Clear();
    menu.Display();
    string ans = menu.YourChoice();
    if (ans == "MainMenu")
    {
        menu = new MainMenu();
    }
    else if (ans == "AddCustomer")
    {
        menu = new AddCustomer();
    }
    else if (ans == "Exit")
    {
        repeat = false;
    }
}
