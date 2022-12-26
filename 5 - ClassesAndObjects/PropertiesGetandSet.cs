using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    //From W3Schools:

    /*
    Before we start to explain properties, we should have a basic understanding
    of "Encapsulation".
    The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. 
    To achieve this, we must:

    >declare fields/variables as private
    >provide public get and set methods, through properties, to access and update the value
    of a private field
     */
    
    //Private variables can only be accessed within the same class (an outside class has no
    //access to it). However, sometimes we need to access them - and it can be done with
    //properties.
    //A property is a special variable that has two built-in methods: a get and a set method.


    public class Movie
    {
        public string title;
        public string director;
        private string rating;

        public Movie(string Movietitle, string MovieDirector, string MovieRating)
        {
            this.title = Movietitle;
            this.director = MovieDirector;
            this.Rating = MovieRating;
        }

        //When movies are rated, there are 5 main types (there are more but 5 is enough
        //for this example):
        //G, PG, PG-13, R, NR
        //So how do we stop a user from setting the rating of a movie as something like "Dog"?
        //or "Cat"? How do we make sure that the rating is always one of the above 5 no matter
        //whether they assign the value during creation of a movie object or by assigning
        //it later using <movieobject>.Rating="Cow" or any other way?
        //By setting the rating attribute as private we can stop them from changing or accessing
        //the variable, but then they can't even set a movie's rating to PG or any of the 5 above.
        //That's where getters and setters come in. Using getters and setters we can provide
        //conditional access to the rating attribute.

        //Creating the Rating property: (Properties are named the same as the variable their
        //referencing but starting with a capital letter)
        
        public string Rating
        {
            get { 
                return this.rating;
                //The code within this method is what will happen when the user tries to
                //access the rating attribute's value. 
            }
            //This get method will return the value of the object's rating when called.
            //So now the user can view a movie's rating as they would with a public
            //attribute.

            set { 
                if(value == "G" || value == "PG" || value == "PG - 13" || value ==  "R" || value ==  "NR"){
                    //the value keyword refers to what the user passes in when they try to 
                    //set the value of the attribute
                    this.rating = value;
                }
                else
                {
                    this.rating = "NR";
                }
                //If the user enters G, PG, PG-13, R, NR then the movie's rating will be set
                //to it, if they try to set the rating to anything other than those 5 it will
                //be auto-set to NR.
            }
        }
    }
}
