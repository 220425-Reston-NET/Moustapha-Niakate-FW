// See https://aka.ms/new-console-template for more information
Console.Clear(); // Will clear the console
Console.WriteLine("Hello, World!"); //WriteLine will write something in the Terminal

//[Class name] [Name object] = new [Class name]();
Car carObj1 = new Car(); 

//Referencing class members within an object
int mile = carObj1.TotalDistancePerFuel();

carObj1.Sum(5, 10);

Console.WriteLine(mile);

Console.WriteLine("End of Method");

string owner = "Fatima";

Car carObj2 = new Car(owner);
Console.WriteLine(carObj2.Owner);
carObj2.Owner = "Halima";
Console.WriteLine(carObj2.Owner);

//Checking if our property constraints is working

carObj2.Fuel = -180;
Console.WriteLine(carObj2.Fuel);

Collections collectObj = new Collections();
collectObj.Collectionmain();

Conversion.ConversionMain();
