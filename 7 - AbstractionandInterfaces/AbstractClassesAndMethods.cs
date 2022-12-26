namespace AbstractionandInterfaces
{
    abstract class AbsClassesandMethods
    {
        //From w3schools:

        /* Data abstraction is the process of hiding certain details and showing only essential
         * information to the user.
         */

        //Recalling encapsulation, it is the process of hiding sensitive data from users.
        //Abstraction and encapsulation may seem the same but they are not.
        //Encapsulation is the process of hiding as much of the internal working of a program as
        //possible. Abstraction is the process of hiding certain specific details and parts of
        //code while still giving the end user essential information.

        /*Abstraction can be achieved with either abstract classes or interfaces (next file).
     
        The abstract keyword is used for classes and methods:

        Abstract Class: is a restricted class that cannot be used to create objects
        (to access it, it must be inherited from another class).
        Abstract Method: can only be used in an abstract class, and it does not have a body.
        The body is provided by the subclass.
    
        An abstract class can have both abstract and regular methods.
        */

        public abstract string showRAM();
        //This is an abstract method. We cannot define it's body here, we have to inherit this
        //method in another class and define it's body there.
        //To give it a body in a subclass we must override it there. All abstract classes
        //are overrideable by default.

        public void showRating()
        {
            //abstract classes can contain normal methods too
            Console.WriteLine("5 Stars!");

        }

        //Abstract classes CANNOT have any objects. We cannot write
        //AbsClassesandMethods abc = new(); THIS WILL RAISE AN ERROR 
    }

    class Phone : AbsClassesandMethods
    {
        public string brand;
        private int ram;
        public double rating;

        public Phone(string phonebrand, int phoneram, double phonerating)
        {
            this.brand = phonebrand;
            this.ram = phoneram;
            this.rating = phonerating;
        }

        public override string showRAM()
        {
            return this.ram + " gb";
        }
    }

    class MainCode
    {
        public static void Main(string[] args)
        {
            Phone MotoG20 = new("Motorola", 8, 4.5);
            Console.WriteLine(MotoG20.showRAM());
            MotoG20.showRating(); //This will show 5 stars as it hasn't been overridden in the Phone class

            //REFER TO INTERFACES

            MyClass myobject = new MyClass();
            myobject.Method1();
            Console.WriteLine(myobject.Method2());
        }
    }
}