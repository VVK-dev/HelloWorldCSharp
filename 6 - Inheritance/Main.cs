namespace Inheritance
{
    public class Start
    {
        //Inheritance is the process of allowing one class to use all the methods of 
        //another class as it's own

        //syntax: <subclassname> : <superclassname>
        //the subclass is the one that's inheriting the superclass's methods

        static void Main(string[] args)
        {
            BasicChef John = new();
            Console.WriteLine(John.MakeSalad());
            Console.WriteLine(John.MakeSpecialDish());

            SpecialChef Jack = new();
            Console.WriteLine(Jack.MakeSalad());
            Console.WriteLine(Jack.MakePasta());
            Console.WriteLine(Jack.MakeSpecialDish());

            //As the SpecialChef class inherited all of the BasicChef class's methods, both 
            //can make a salad. But only the Special Chef Jack can make pasta as the method
            //is defined only in the Special Chef subclass.
        }
    }
}