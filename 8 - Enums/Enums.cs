namespace Enums
{
    //An enum is a sort of special "class" that contains a group of constants.
    //Constants are unchangeable, read-only variables.

    //To create and enum we use the same syntax we would to create a class, but use the enum
    //keyword instead.

    public enum Yo
    {
        //To create a constant we simply declare its name. We can declare more constants by
        //adding a comma at the end of the constant. We need not start on a new line to 
        //declare a new constant, we can use the same line to declare multiple constants
        //separated by commas.

        //Enums function similarly to dictionaries; all constants in an enum have 2 values
        //associated with them : A string value that is equal to the constant's
        //name and an integer value equal to their index (which starts at 0 like a normal
        //array).

        //We can change the integer value associated with them by using an equal-to sign and
        //declaring it's value like a normal variable.
        //After changing the integer value associated with a constant, all other constants
        //after that one will have their values changed to be in line with the one before it
        //, kinda like in an excel spreadsheet. So if we change the 3rd cosntant's value to
        //27, the 4th constant's value becomes 28 even though it's index is still 3.

        Yo1, //0
        Yo2, //1
        Yo3 = 27, Yo4 //28

    }

    public class EnumsandExceptionsMain{

        //enums can also be created within a class with syntax similar to that of an array

        public enum Hi { Zero, Uno, Dos }

        //they cannot be created within methods, however

        public static void Main(string[] args)
        {
            //When we try to directly print or use a constant, by default it's string value
            //is always used 

            Console.WriteLine(Yo.Yo1); //This will display Yo1 as the string value of a 
                                       //constant is it's own name

            //To display a constant's integer value, we must convert it to an integer then
            //display it.
            
            Console.WriteLine(Convert.ToInt32(Yo.Yo3));

            //When we want to save a constant's integer value to a variable, we can use a
            //special method of typcasting specific to enums:
            
            int num1 = (int) Yo.Yo4;
            
            //This method does not work normally for any other type of value
            /* string x = "1";
            int num2 = (int) x; */ //This will raise an error

            Console.WriteLine(num1);

            Console.WriteLine(Convert.ToInt32(Hi.Uno));

            /* From W3Schools:
             *Enums are often used in switch statements to check for corresponding values:
             
              enum Level 
              {
                Low,
                Medium,
                High
              }
              static void Main(string[] args) 
              {
                  Level myVar = Level.Medium;
                  switch(myVar) 
                  {
                  case Level.Low:
                      Console.WriteLine("Low level");
                      break;
                  case Level.Medium:
                      Console.WriteLine("Medium level");
                      break;
                  case Level.High:
                      Console.WriteLine("High level");
                      break;
               } */

        }
    }
}