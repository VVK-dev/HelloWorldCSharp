namespace HelloWorldCSharp //This should be namespace Intro, namespace is project name generally
{
    class Intro
    {
        //C# is.. funky. So a class is simply a container of code, and like java
        //the Main method is a thing.
        //BUT unlike java (and very much like python) all of this fluff is optional.
        //Creating the namespace, class and using the main function/method is completely
        //optional and NOT NECESSARY.
        //for eg: we can create a file like this:
        //
        //Console.WriteLine("Hello, World!");
        //
        //and if we execute a file like this with just 1 line, it works compeltely OK, like python
        //NOTE: Unlike java, the class's name doesn't have to be the same as the file's name
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            // variables in c# are created the same way as they are in java

            string y = "yo";
            Console.WriteLine(y);

            //and like in java, we dont need to assign a value to a variable right away,
            //we can just declare it first

            int num;
            num = 1;
            Console.WriteLine(num);
            Console.WriteLine(y+" "+num);

            //float is unprecise decimal number, double is moderately precise decimal
            //and decimal is super precise decimal
            //use decimal for money and other impo stuff, for most others double is fine

            float num2;
            double num3;
            decimal num4;

            //C# is actually alot like python: like python we can print out individual 
            //characters in a string using <string>[index], there
            //also exists a .contains(<stufftosearchfor>) method which will check if a string
            //contains whatever's in the brackets

            string a = "C# is like Python";
            Console.WriteLine(a.Contains("Python"));
            Console.WriteLine(a[1]);

            //there also exists a super useful method: <string>.IndexOf("<stufftosearchfor>")
            //this will not only tell us the index postion of certain character(s) but also
            //whether they exist in the string or not

            Console.WriteLine(a.IndexOf("Python"));

            //just write a. and navigate through the list of all possible functions, there's
            //ALOT and most of them are very similar if not the same as those in python

            //math works the same as in all other languages, nothing special to know about

            //Unlike python, normal variables can't be null. Normal variable types
            //aren't nullable. To create a variable that can have it's value as null
            //we have to add a question mark at the end of the data type during
            //declaration

            string? q;
            q = null;


            /*SLIGHTLY ADVANCED STUFF - DON'T LOOK AT THIS UNTIL UR DONE WITH MOST OF THE OTHER PROJECTS
             * IN THIS SOLUTION

            >> We can use the @ symbol in front of a string to delcare it as a "string verbatim". It is
            exactly the same as a raw string in python.

            >> We can use the $ in front of a string to implement string interpolation. String 
            interpolation allows us to write normal code and variables in a string. It's the same as format 
            strings in python.

            eg:

            static int add (int num1, int num2){
                int num3 = num1 + num2;
                return num3;
            }

            static void Main(String[] args){
                Console.WriteLine($"The sum of 3 and 5 is {add(3,5)}.")

             */
        }
    }
}