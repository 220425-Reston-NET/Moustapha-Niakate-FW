//This is how you create a class by using the class keyword
//public is there to make the class available for everyone 
public class Car 
{
    //this is a field
    //it is used to store information or define the current state of the obj
    private string _color;
    private string _Owner; 
    private int _fuel;
     private int _gallonPerMile;

        //this is a method
        //A way to represent behavior /function and it will run multiple lines of code
        //Void means the Method will not return anything 
        //Any other datatype, the method will expect to return that datatype
        public int TotalDistancePerFuel()
        {
            Console.WriteLine("Current Fuel: " + _fuel + " This is the owner: " + _Owner);
            Console.WriteLine($"Gallon Per Mile: {_gallonPerMile} this is the owner: {_Owner}");

            Console.WriteLine(" This is how many miles: " + _fuel/_gallonPerMile);
            //Return keyword is what the method will give back
            return _fuel/_gallonPerMile;

        } 
        //Methods can also have parameters
        //Parameters are implemented by adding in datatypes inside of the parenthesis
        // The comma is used if a method
        
        public void Sum(int num1, int num2)
        
        {
            Console.WriteLine(num1+num2);
        }

        //This is a constructore
        //It is a special method that will run whenever you create an object

        public Car()
        {
            _color = "Blue";
            _Owner = "Moustapha";
            _fuel  = 100;
            _gallonPerMile = 5;
        }

        public Car(string P_owner)
        {
            _Owner = P_owner;
        }
        //This is Property
        //Gives us the flexibility to check the data being stored is correct, let only certain things access data, make things read or read only

        public string Owner
        {
            //The get keyword is how the data is going to be shared 
            get {return _Owner + " is the owner of this car.";}
            // set keyword is how you change the data that is being stored
            set {_Owner= value+ " Owner";}
        }

        //Fuel can only hold a numbers from 0 to 100
        public int Fuel
        {
            get {return _fuel;}
            set
            {
             if (value <= 100 && value >- 0)
             {
                 _fuel = value;
             }
              else
              {
                  _fuel = 100;
                  Console.WriteLine(" Fuel can only hold forom 0 to 100");
              }   
             }
            }
}