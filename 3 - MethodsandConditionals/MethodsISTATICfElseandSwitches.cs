namespace HelloWorldCSharp
{
    public class MethodsISTATICfElseandSwitches
    {
        static string Yo(string name)
        {
            //creating a method in C# is the exact same as it is in java
            //<static/virtual/etc./nothing> <returntype> <methodname>{
            //}
            
            //A Static method is one that belongs to the class and doesn't require an object
            //of that class to be called. Refer to the ClassesandObjects project for more
            //info on static.

            return "yo " + name;
        }
        
        //C# supports method overloading, which means that we can create multiple methods with
        //the same name that can do different things as long as they take diferrent parameters
        //and/or return different types

        static int Yo()
        {
            return 0;
        }


        static void Main(string[] args)
        {
            Console.WriteLine(Yo("VVK"));
            Console.WriteLine(Yo());

            //CONDITIONAL STATEMENTS

            //if statements are the same as in java, self explanatory

            Console.WriteLine("Enter the boolean values of x and y:");
            bool x = Convert.ToBoolean(Console.ReadLine());
            bool y = Convert.ToBoolean(Console.ReadLine());

            if (x && y) //&& is and, || is or
            {
                //here we dont have to write if(x==true && y==true) cuz by default
                //they are true

                Console.WriteLine("x and y are true");
            } else if(!x && y) //remember, ! is NOT
            {
                Console.WriteLine("x is false and y is true");
            } else if (x && !y)
            {
                Console.WriteLine("x is true and y is false");
            } else if (!x && !y)
            {
                Console.WriteLine("neither x nor y are true");
            }


            //TERNARY OPERATOR (SHORT HAND IF-ELSE STATEMENTS)

            //C# has a nifty simplified version of the regular if-else statement to reduce multiple lines of code
            //into 1 using whats called the ternary operator (?) (question mark is the ternary operator).

            //<variable> = (<condition>) ? expressionTrue : expressionFalse;

            //We can add multiple conditions using the && binary and operator


            int time1 = 10;
            int time2 = 10;

            string abc = (time1 > 15) && (time2>15) ? "time greater than 15" : "time less than 15";

            Console.WriteLine(abc);

            //We can also add multiple outcomes i.e. multiple ifs-elses using a nested ternary operator.

            //<variable> = (<condtion>) ? expressionTrue : (<condition>) ? expressionTrue : (<condition>) ? 
            // expressionTrue ... ;

            //It functions like multiple if-else-if combined into one.

            string def = (time1 > time2) ? "time1 greater than time2" : (time1 == time2) ? "time1 equal to time2" :
                "time1 less than time2";

            //The above example works like: if time1>time2 do this else if time1==time2 do this else do this


            //SWITCH STATEMENTS are the same as in other languages, they function
            //like a bunch of if statements or if-else-if statements if you use the break
            //keyword

            //Taken from W3Schools:
            //The switch expression is evaluated once
            //The value of the expression is compared with the values of each case
            //If there is a match, the associated block of code is executed

            Console.WriteLine("Enter the day's number in the week");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1:
                    Console.WriteLine("Today is Sunday");
                    break;
                    //When C# reaches a break keyword, it breaks out of the switch block.
                    //This will stop the execution of more code and case testing inside
                    //the block.
                    //If we want c# to keep executing the switch code to check if 
                    //the condition satisfies multiple cases, we can skip the break
                    //keyword.
                case 2:
                    Console.WriteLine("Today is Monday");
                    break;
                case 3:
                    Console.WriteLine("Today is Tuesday");
                    break;
                case 4:
                    Console.WriteLine("Today is Wedenesday");
                    break;
                case 5:
                    Console.WriteLine("Today is Thursday");
                    break;
                case 6:
                    Console.WriteLine("Today is Friday");
                    break;
                case 7:
                    Console.WriteLine("Today is Saturday");
                    break;
                default:
                    //the defualt section is executed if none of the cases are satisfied
                    //the defualt section is optional
                    Console.WriteLine("All you had to do was enter a number between 1 and 7 bruh.");
                    break;
            }
        }
    }
}