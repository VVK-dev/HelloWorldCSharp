using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    public class AdvFileHandlingStreamReaderandWriter
    {
        //StreamReaders and StreamWriters are very simple. They are basically classes that allow us to
        //create objects that can access a stream of information (in this case a filestream).

        //STREAMREADER

        //The simple constructors (several complicated overloads not talked about here):


        /*
          Constructor Overload                          Explanation
         
          StreamReader(Stream)                          Initializes a new instance of the StreamReader 
                                                        class for the specified stream. We can use this
                                                        method after we create a FileStream with read 
                                                        permission to read the file.

          StreamReader(String path)                     Initializes a new instance of the StreamReader 
                                                        class with the path of the file.
        */

        //As stated in AdvFileHandling - FileStreams.cs, a simple way to create a file stream is to use
        //File.Open, File.OpenRead, File.Openwrite, etc and their overloads.

        //So we can use StreamReader <variablename> = new StreamReader(File.Open(<path>,<filemode>,etc)) as
        //another implementation of the StreamReader(<Stream>) constructor.



        //Methods (There are other method overloads but I won't be talking about them here as it gets
        //complicated):

        /*
                  Method                        Explanation
        
        <StreamReaderVariable>.Read()           Reads the next character from the input stream and advances
                                                the pointer by 1 character. This method returns an int32
                                                object that we can convert to a char. If no more characters
                                                are available to be read, it returns -1.
        
        <StreamReaderVariable>.ReadLine()       This method returns a string containing the next line from 
                                                the input stream or null if the end of the input stream has
                                                reached.

        <StreamReaderVariable>.ReadToEnd()      This method returns a string containing all characters
                                                from the pointer's current position to the end of the file.
                                                Returns an empty string if already at the end.
        
        <StreamReaderVariable>.Peek()           This method returns an integer value equal to the next
                                                character in the stream when typecasted to char. Returns
                                                -1 if no characters are left to be read. This method does
                                                not move the pointer.

        <StreamReaderVariable>.Close()          This method closes the streamreader object, the underlying
                                                stream and releases any system resources associated with
                                                the reader.

        <StreamReaderVariable>.Dispose(Boolean) Closes the underlying stream, releases the unmanaged 
                                                resources used by the StreamReader, and optionally 
                                                releases the managed resources. When you have finished 
                                                using a StreamReader object, you should dispose of it 
                                                either directly or indirectly. To dispose of it directly, 
                                                call this method in a try/catch block. To dispose of it 
                                                indirectly, we can use the using keyword to auto-dispose
                                                it after the code executed in it's block is complete.
         */


        //STREAMWRITER

        //The simple constructors (several complicated overloads not talked about here):

        /*
        
            Constructor                             Explanation 

        StreamWriter(Stream)                        Initializes a new instance of the StreamWriter class for 
                                                    the specified stream using UTF-8 encoding.     

        StreamWriter(String path)                   Initializes a new instance of the StreamWriter class for 
                                                    the specified file using UTF-8 encoding. 

        StreamWriter(String path, Boolean append)   Initializes a new instance of the StreamWriter class 
                                                    for the specified file by using the default encoding.
                                                    If the file exists, it can be either overwritten or 
                                                    appended to. If the file does not exist, the append 
                                                    variable does nothing and this constructor creates a 
                                                    new file.

         */

        //As stated in AdvFileHandling - FileStreams.cs, a simple way to create a file stream is to use
        //File.Open, File.OpenRead, File.Openwrite, etc and their overloads.

        //So we can use StreamWriter <variablename> = new StreamWriter(File.Open(<path>,<filemode>,etc)) as
        //another implementation of the StreamWriter(<Stream>) constructor.


        //Methods (Complicated Methods not talked about here):


        /*
                Method                                      Explanation

        <StreamWriterVariable>.Write(Char)	                Writes a character to the stream.
         
        <StreamWriterVariable>.Write(String)	            Writes a string to the stream.     
         
        <StreamWriterVariable>.Write(Char[])	            Writes a character array to the stream.
         
        <StreamWriterVariable>.WriteLine(String)	        Writes a string to the stream, followed by 
                                                            a line terminator.         
        
        <StreamWriterVariable>.Close()                      Closes the Writer and the Stream.

        <StreamWriterVariable>.Dispose()                    Releases the unmanaged resources used by 
                                                            the StreamWriter, and optionally the 
                                                            managed resources. We can auto-dispose with
                                                            the using keyword.
         
         */
    }
}
