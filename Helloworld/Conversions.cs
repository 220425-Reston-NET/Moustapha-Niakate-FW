public class Conversion
{
    //Static keyword will make whatever class member belong to the class itself
    //For us, it means we don't to create an object out of this class to use it 
    public static void ConversionMain()
    {
        //General coding terms
        //Implicit - just means something is done automatically (usually the compiler)
        //Explicit - just means you have to write some syntax to do something or tell the compiler to do something 

        Console.WriteLine("=== Conversion Demo ===");
        int number = 10;
        double numberDecimal = 76.3;
        string word = "Hello";

        //Implicit conversion
        //The computer/Compiler will automatically convert one datatype to another without you needing to specify anything
        //The general rule is if you are going from a datatype to another datatype without losing information, it will be implicit conversion
        Console.WriteLine("Implicit");
        
        //double datatype can set it values using an int datatype
        numberDecimal = number;
        Console.WriteLine(numberDecimal);
        //Explicit Conversion 
        //You have to write a syntax to tell the compiler/Computer to do the conversion anyway regardless of the potential of losing data
        Console.WriteLine("=Explicit");
        numberDecimal = 76.3;

        //A Cast is required 
        //Syntax: (datatype)variableName;
        number = (int)numberDecimal;
        Console.WriteLine(number);

        //More Explicit Conversion
        string numberString = number.ToString();
        Console.WriteLine(numberString);

        //Converting string into numerical values
        string doubleString = "438.1239";

    }
}