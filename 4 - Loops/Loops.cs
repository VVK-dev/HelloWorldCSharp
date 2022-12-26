namespace HelloWorldCSharp
{
    public class Loops
    {
        static void Main(string[] args)
        {

            //WHILE LOOPS

            int index = 1;
            while (index <= 5)
            {
                //same as java
                Console.WriteLine(index);
                index++;
                //if we comment out the increment statement above, we will get and infinite 
                //loop, and unlike python c# WILL execute the infinite loop
            }

            //DO-WHILE LOOPS

            //do while loops in c# are the same as in java, a do while loop will execute
            //the code once BEFORE checking the while condition

            do
            {
                Console.WriteLine(index);
                index++;
            } while (index <= 5);


            //Guessing game for practice:

            /*guesses = 1;
             do{
               Console.Write("Enter a number between 1 to 5: ");
               int inp = Convert.toInt32(Console.ReadLine());
               guesses++;
             }while(inp!=1 && guesses<=3);
             if (guesses>3){
                Console.WriteLine("You lost :(");
             }else{
                Console.WriteLine("Bingo Bongo You did it!")
             }*/


            //FOR LOOPS

            //for loops are structured the same way they are in java:

            //for(<variable initialization>;<loop condition>;<iteration execution>){
            //
            //}

            //The main difference between while and for loops is that for loops require
            //a variable to be created within them to run, the whole purpose of using
            //a for loop over a while loop is that for loops will always be able to keep
            //track of that variable.

            for(int i = 0; i < 5; i++)
            {
                //Here, we initialize a variable i, give the condition that the loop should
                //run as long as i is less than 5, and we give the iteration exection, i.e.
                //what will happen everytime the loop is executed (apart from the loop's
                //code block where this comment is written)

                Console.WriteLine(i);
            }

            //FOR-EACH LOOPS


            //One annoying thing that c# has in common with java is that, unlike python,
            //arrays cant be printed out on their own. To display an array, we can either use
            //a for loop or a type of loop that exists exclusively to iterate through arrays
            //called a foreach loop.

            //My current understanding of it is that arrays aren't actually objects on their own,
            //they're simply containers to store objects so when we try to print an array
            //using console.write only it's memory address gets printed
            //(future me pls fact check this).

            //The syntax for a foreach loop is the same as a for loop in python:

            //foreach(<variabletype> <variablename> in <arrayname){
            //
            //}

            int[] nums = { 1, 2, 3, 4 };

            foreach (int i in nums)
            {
                Console.WriteLine(i);
            }

     

            //Break and continue function the same in c# for while and for loops as in all
            //other languages.


            //Refer to method below.

            Console.WriteLine(Expo(2, 2));

        }

        //Creating a method to find exponents, loops practice
        static Int32 Expo(int num, int pow)
        {
            for (int i = 0; i < pow; i++)
            {
                num *= num;
            }
            return num;
        }

    }
}