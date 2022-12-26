using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractionandInterfaces
{
    interface IInterfaces 
    {
        //An interface is like an abstract class but can ONLY contain abstract
        //methods and properties (with empty bodies).

        //The main difference between interfaces and regular abstract classes is that
        //unlike abstract classes, interfaces cant contain any attributes or variables or 
        //fields. Like abstract classes, interfaces don't support object creation either;
        //we can't create any instances of interfaces.

        //The main reason to use interfaces over regular abstract classes is that c# does
        //not support multiple inheritance but does support multiple interface
        //implementation (implementation is basically inheritance but for interfaces).

        //It is considered good practice to name interfaces with a "I" at the beginning,
        //hence why this interface is called IIinterfaces, not a typo.

        //By default, all parts of an interface are abstract and public.

        void Method1();

        //As they are all abstract, the body of methods is given by the class that is
        //implementing the interface, called the implement class.

        //To implement an interface, we use the : symbol(just like with inheritance).
        //Note that you do not have to use the override keyword when implementing an
        //interface.

    }

    interface IInterface2
    {
        string Method2();
    }

    class MyClass : IInterfaces, IInterface2
    {
        // We can implement multiple interfaces by separating them with a comma
        public void Method1()
        {
            Console.WriteLine("Yo1");
        }
        public string Method2()
        {
            return "Yo2";
        }
    }

    //REFER TO AbstractClassesAndMethods FOR MAIN METHOD STATEMENTS
}
