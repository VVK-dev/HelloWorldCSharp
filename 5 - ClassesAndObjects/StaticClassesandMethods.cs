using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public static class StaticClassesandMethods
    {
        //Static methods: A static method is one that, like a static attribute, belongs
        //to the class itself and not to any one individual object

        //So a static method doesn't need the creation of an object to be called

        //We can look throughout this solution for examples of static methods, we have used them
        //several times already.

        //A static class is a class that exists solely to contain static methods, we can't
        //create any objects of such a class, we can only use them to call static methods

        //An example of this is the Math class. We can't create any objects of the Math class
        //but we can call some methods from the Math class like Math.sqrt(),etc.

        static void yo()
        {
            Console.WriteLine("Yo");
        }
    }
}
