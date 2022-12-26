using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    public class Song
    {
        //A static class attribute is an attribute of a class that is shared by all objects
        //and instances of that class. A static attribute is a variable contained within
        //the class itself and not specific to individual objects.

        public string Name;
        public string Artist;
        public static int TotalNumberofSongs = 0;

        public Song(string SongTitle, string SongArtist)
        {
            this.Name = SongTitle;
            this.Artist = SongArtist;
            TotalNumberofSongs += 1;
            //everytime we create a song object, the total number of songs increases by 1
            //this attribute isn't specific to each song and unlike the other attributes we
            //don't have to declare it's value during object creation
        }

    }
}
