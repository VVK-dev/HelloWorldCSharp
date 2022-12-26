namespace ClassesAndObjects
{
    public class ClassesobjsMain
    {
        //classes allow us to create our own data types
        //to create a new class in a c# proj using vs, right click on the project's name and
        //right click it, hover over "Add" and select class or you can select new item and then
        //choose class from there

        //In Book.cs we have created a Book class that we will use here

        static void Main(string[] args)
        {
            //an object is an instance of a class

            Book book1 = new Book("Dune","Frank Herbert",500);

            //we can also just type new() for the sake of simplicity

            Book book2 = new("The SCAM","Sucheta Dalal and Debashis Basu",300);

            //everytime we create a book we're basically calling the book method and passing
            //some parameters to it, so if we write something like "Console.Writeline("Hi");"
            //in it, everytime we create a book object "Hi" will be displayed onto the screen

            Console.WriteLine(book1.pgover400());
            Console.WriteLine(book2.pgover400());

            //REFER TO GETTERS AND SETTERS

            Movie shrek = new("Shrek", "Adam Adamson", "PG");
            Movie avengers = new("Avengers", "Joss Whedon", "Monke");

            Console.WriteLine(shrek.Rating); //This prints PG
            Console.WriteLine(avengers.Rating); //This prints NR

            //REFER TO STATIC CLASS ATTRIBUTES

            Song smiteceltic = new("Smite Celtic Theme","Smite Orchestra");
            Song jkt = new("Jarls, Karls and Thralls", "JasperKyd and others");

            Console.WriteLine(Song.TotalNumberofSongs);
        }
    }
}