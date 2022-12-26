using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    public class AdvFileHandlingFileStreams
    {
        public static void FileStreams()
        {
            //The main topics in advanced file handling are the streamreader and streamwriter.
            //But first, what is a stream? A stream is basically a connection to something that allows
            //us to read and manipulate that thing's contents. What we will be looking at is a FileStream.

            //A FileStream is a class that we can use to create a filestream object that will provide
            //a stream for us to a file. It's basicallly the equivalent of using the open keyword
            //in python. And like in python we need a reader and writer to access the file's contents and
            //manipulate them. Their equivalents are the streamreader and streamwriter. The difference here
            //though is that in c# the streamwriter, streamreader and FileStream can be used independently
            //of each other. We can use a filestream to do several different things including reading
            //and writing, we don't need to use a streamreader or writer for that, and the streamreader
            //and writer can open files on their own without the filestream. 

            //So generally we use the reader and writer when we want to only write or only read
            //and the filestream if we want to do both or something else.

            //From the C# docementation:

            /*
             * Use the FileStream class to read from, write to, open, and close files on a file system,
             * and to manipulate other file-related operating system handles, including pipes, standard
             * input, and standard output.
             */

            //In python we can use the "with" keyword to automatically close a file when we open it.

            //Similarly we can use the "using" keyword to automatically close the file and dispose of
            //unmanaged resources when we use the filestream, streamreader or streamwriter.

            //We can also use the Stream.Close() method to manually close it.

            //The Filestream class has several constructors, here I will go over the simple ones (properties
            //explained after):


            /*
             *              Overload                                    Explanation
             * 
             * FileStream(Path, FileMode)                           Initializes a new instance of the 
             *                                                      FileStream class with the specified 
             *                                                      path and file mode.
             * 
             * 
             * 
             * FileStream(Path, FileMode, FileAccess)               Initializes a new instance of the 
             *                                                      FileStream class with the specified 
             *                                                      path, file mode, and read/write 
             *                                                      permission.
             * 
             * FileStream(Path, FileMode, FileAccess, FileShare)	Initializes a new instance of the 
             *                                                      FileStream class with the specified 
             *                                                      path, file mode, read/write 
             *                                                      permission, and sharing permission.
             *                                                      
             */

            //Explanation of the properties above:

            //FileMode:

            //1)FileMode.Open - Specifies that the operating system should open an existing file.
            //A FileNotFoundException exception is thrown if the file does not exist.

            //2)FileMode.Create - Specifies that the operating system should create a new file.
            //If the file already exists, it will be overwritten. This requires Write permission (Refer to
            //FileAccess for more info).

            //3)FileMode.OpenOrCreate - Specifies that the operating system should open a file if it
            //exists; otherwise, a new file should be created.

            //4)FileMode.CreateNew - Specifies that the operating system should create a new file.
            //This requires Write permission. If the file already exists, an IOException exception is
            //thrown.

            //5)FileMode.Append - Opens the file if it exists and seeks to the end of the file, or
            //creates a new file. FileMode.Append can be used only in conjunction with FileAccess.Write.
            //Trying to seek to a position before the end of the file throws an IOException exception,
            //and any attempt to read fails and throws a NotSupportedException exception.

            //6)FileMode.Truncate - Specifies that the operating system should open an existing file.
            //When the file is opened, it should be truncated so that its size is zero bytes.
            //This requires Write permission. Attempts to read from a file opened with FileMode.Truncate 
            //cause an ArgumentException exception.

            //FileAccess:

            //1)FileAccess.Read - Read access to the file.

            //2)FileAccess.Write - Write access to the file.

            //3)FileAccess.ReadWrite - Read and write access to the file.

            //FileShare:

            //This property controls whether or not and how if so the file is shared between multiple
            //FileStream objects. Sharing is basically just allowing other FileStream objects to use the
            //file while the current FileStream object uses the file without having to close the file and
            //re-open it.

            //1)FileShare.None - Declines sharing of the current file. Any request to open the file
            //(by this process or another process) will fail until the file is closed.  

            //2)FileShare.Read - Allows subsequent opening of the file for reading. If this flag is not
            //specified, any request to open the file for reading (by this process or another process)
            //will fail until the file is closed. 

            //3)FileShare.Write - Allows subsequent opening of the file for writing. If this flag is not
            //specified, any request to open the file for writing (by this process or another process)
            //will fail until the file is closed. 

            //4)FileShare.ReadWrite - Allows subsequent opening of the file for reading or writing.
            //If this flag is not specified, any request to open the file for reading or writing
            //(by this process or another process) will fail until the file is closed.

            //5)FileShare.Delete - Allows subsequent deleting of a file.

            //6)FileShare.Inheritable - Makes the file handle inheritable by child processes.

            
            
            //So remember how in BasicFileHandling.cs we used the File class and it's methods to perform
            //simple functions on file in a simple way?

            //So there is one particular method of the file class that opens a filestream for you to a
            //specific file:


            //File.Open(<path>,<Filemode>,<all other file options can be optionally added here>)

            //it's a simple way to create a filestream and access a file.
        }
    }
}
