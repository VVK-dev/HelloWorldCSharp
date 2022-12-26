using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class BasicChef
    {
        //Here we are creating a BasicChef class that can make certain dishes

        public string MakeSalad()
        {
            return "The Chef Makes Salad";
        }
    
        public string MakeNoodles()
        {
            return "The Chef Makes Noodles";
        }

        public virtual string MakeSpecialDish()
        {
            //the virtual keyword allow this method to be overridden in any subclasses

            return "The Chef Makes A Sandwich";
        }

    }
}
