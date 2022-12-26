
namespace HelloWorldCSharp
{
    public class InputTypecastingArrays
    {
        public static void Main(string[] args)
        {
            //We can use Console.Readline() to accept input from the user

            Console.Write("Enter your name: ");
            string? a = Console.ReadLine();
            Console.WriteLine("yo " + a);

            //ARRAYS

            //we create arrays the same ways as in java

            int inp1 = 0;

            int[] nums = {1,2,3,4};
            nums[2] = inp1;
            Console.WriteLine(nums[2]);

            //and like in java, this way also works:

            int[] nums1 = new int[4];

            //and once again like java, we can't simply print out an array - we have to use a 
            //foreach loop (loops explained later > in Loops - 4)to do it.

            //the thing is tho that arrays cannot change their size, if we create an array with 5 elements
            //it must always have 5 elements, no more no less.
           
            //If we want to create an array that can hold all data types then we have to 
            //create an object array:

            object[] arraythatcanholdalldatatypes = new object[4];

            //C# also supports a Sort function which has many variations.

            Array.Sort(nums);

            //The annoying thing about this method tho is that it doesn't output a new array that is a
            //sorted version of the existing array, it just sorts the existing array.

            //To create a new version of an existing array we have to clone it:

            int[] nums2 = (int[])nums.Clone();

            //We can use this in tandem with the sort method to get a sorted copy of an array while still
            //keeping the original.

            //ADVANCED - COME HERE AFTER LINQ AND ANONYMOUS METHODS

            //Since arrays are immutable, we cannot remove or add any elements to it.

            //BUT we can if we use this specific method:

            //<array> = <array>.Where(x => Array.IndexOf(<array>,x) != <indexofelementtoremove>).ToArray();



            //LISTS

            //Lists also exist in c#. They are basically arrays that can freely change in size.
            //Memory wise, arrays are a bit faster than lists so if we know exactly how many elements
            //a collection will have at all times we can use an array isntead of a list for better
            //performance.

            //Most of the time we will be using lists instead of arrays as they are easier to work with.

            //syntax:

            //List<type> <variablename> = new(); to just create a list with no items
            //OR
            //List<type> <variablename> = new(){<elements>} to create a full list.

            List<int> l = new();

            List<int> l1 = new(){1,2};

            //code wise, lists function pretty much the same as arrays.

            //we can use <listname>.add(<element>) to add an element to a list.

            l.Add(1);

            //we can merge to lists or arrays together using <listname>.AddRange(<nameofothercollection>);

            l.AddRange(nums);

            //to remove the first occurence of a particular element we can use l.Remove(<element>)

            l.Remove(1);

            //we can remove the element at a particular index using l.RemoveAt(<index>)

            l.RemoveAt(0);

            //we can also use foreach loops with lists (explained in Loops.cs)

            //Lists have a millions different methods we can use with them, not going to go over any others
            //right now.

            //INDICES

            //In python -ve numbers represent the index of elements in a list backwards. In c# this will lead to
            //an out of range exception. Indixes of elements in a collection from the end are represented by the
            //carat ^ sign.

            Console.WriteLine(l1[^1]); // this will print the last element of the list

            //backwards indices start with 1 instead of 0



            //TYPECASTING

            //We can use Convert.to<type>(<valuetobeconverted>) to convert a value from
            //one data type to another

            Console.Write("Enter a number: ");
            inp1 = Convert.ToInt32(Console.ReadLine()); //Int32 = 32 bit integer
            Console.WriteLine(inp1);

            //This won't work if the user enters a decimal, so we can use
            //doubles instead of int

            Console.Write("Enter a number: ");
            double inp2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(inp2);

            //We can also use (<type>) <variable> to convert said variable to said type.

            int num = 0;

            double num1 = (double)num;

            //To get the type of a variable we can use the <variable>.GetType() method.

            //We can also use the as keyword=> <variable> as <type>


            //To check if the type of a variable is a particular type we can simply use "if <variable> is <type>{ }
            //or use a sub method of the GetType() method: <variable>.GetType().Equals(typeof(<type>));

            //PARSING FOR TYPECASTING

            //Parsing is the process of interpreting a value of one type as another.
            //It's pretty much the exact same as conver except for the following:

            //1) Convert can take any object as an argument, including objects of a custom type whereas Parse can only take
            //strings as arguments
            //2) If we give a null argument, the Convert methods returns 0 but the Parse emthod will throw an
            //ArgumentNullException   

            string b = "1";

            int c = int.Parse(b);
        }
    }
}