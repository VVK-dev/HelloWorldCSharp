using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    class Book
    {
        //We can create some attributes for this class:

        public string title;
        public string author;
        public int pages;

        //Variables declared directly in classes (like the ones above)
        //are aka fields or attributes.

        //By default, all variables in a c# file are private unless specified otherwise.
        //So variables without the private or public keywords in front of them are private
        //automatically and inaccesible in other files.
        //We want these attributes to be public so that we can create a an object of this class
        //in another file and access these values there.

        //Curiously this same behaviour is not shown by classes, all classes are avaiable to use
        //in all other files of the same project if we don't put any access modification
        //keyword (public,private,etc.) in front of it.

        //ACCESS MODIFIERS

        //From W3Schools:

        /*
        C# has the following access modifiers:

        public      The code is accessible by all other classes
        private     The code is only accessible within the same class
        protected   The code is accessible within the same class, or in a class that is 
                    inherited from that class.
        internal    The code is only accessible within its own assembly, 
                    but not from another assembly.
        */

        //CONSTRUCTOR METHODS

        //A constructor method is a method that will allow us to easily create an object
        //of a class.

        //A constructor method's name is always the name of the class

        public Book(string booktitle, string bookauthor, int bookpages)
        {
            this.title = booktitle;
            this.author = bookauthor;
            this.pages = bookpages;

            //The 'this' keyword refer's to the current instance of the class
            //so if we create an object book1 of the Book type, the this keyword will refer to
            //book1.

            //Everytime we create a book we're basically calling this method, i.e. the Book method
            //and passing some parameters to it, so if we write something like
            //"Console.Writeline("Hi");" in this method, everytime we create a book object "Hi"
            //will be displayed onto the screen
        }
    
        //Recall that C# also supports method overloading, so we can have multiple
        //constructor methods all having the name the of the class if the return and/or
        //use parameters of different types
    
        //OBJECT METHODS

        //Object methods are methods that we can use on objects of a class

        public bool pgover400()
        {
            if (this.pages>400){
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
