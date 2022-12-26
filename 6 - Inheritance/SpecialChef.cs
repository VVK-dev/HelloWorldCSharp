using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public sealed class SpecialChef : BasicChef //The sealed keyword means that this class's
     //methods can't be inherited into any other subclasses
    {
        //The SpecialChef has inherited all the methods of the BasicChef

        //Any methods we create in this class can now be used along with those inherited
        //from BasicChef

        public string MakePasta()
        {
            return "The Special Chef makes Pasta";
        }

        public override string MakeSpecialDish()
        {
            //We can override virtual methods using the override keyword 
            return "The Special Chef Makes Soup";
        }

    }
}
