namespace FileHandling
{
    public class BasicFileHandling
    {
        public static void BasicMain()
        {
            //File Handling in C# is a big topic. Like in python there are the simple commands to read, write,
            //append, etc. text in/to a file but along with those c# has several more commands and alot of
            //modifiers and modified versions of these commands as well for more advanced tasks.

            //In this file we'll go over the basic commands and some modified versions of them.

            //FILES IN C#

            //In c#, file handling methods are provided by the File static class. As it's a static class, we
            //can't create and file objects, we can only use the static methods provided by it.
            //As a result, most file methods take a path argument which should contain the path of the target
            //file.

            //To be able to use the file class, we have to import the System.IO namespace. But as it is imported
            //by default (since the entire System namespace is imported by default), we don't actually need to
            //separately import it.

            //List of Basic File methods:

            /*
            Method                                  Function 

            File.Create(<path>);                    Creates a file at the specified location. If the file
                                                    already exists it will be overwritten.
             
            File.ReadAllText(<path>);               Returns the contents of a file.
            
            File.WriteAllText(<path>,<text>);       Writes text to a file. If the file already exists, it
                                                    is overwritten.
            
            File.AppendAllText(<path>,<text>);      Appends text to a file. Nothing is overwritten.

            File.Delete(<path>);                    Deletes a file.
 
            File.Copy(<path>,<destinationpath>,<boolean overwrite>);    Copies the contents of a file and creates
                                                                    a new file with the same contents.
                                                                    Will not overwrite unless the over-
                                                                    write parameter is True. 
                                                                    The overwrite parameter is optional.

            File.Replace(<path>,<destination>,<backuppath>);    Replaces the contents of a file with that
                                                                of another. Can optionally create a backup
                                                                of the original file. The backuppath is 
                                                                a required argument but nullable and
                                                                therefore optional.

            File.Exists(<path>);                    Checks whether a file exists. Returns a boolean value.    

            
            !!NOTE: ALL OF THESE METHODS AUTOMATICALLY CLOSE THE FILE WHEN THEY FINISH (EXCEPT FOR CREATE)!!
             
             */


            File.WriteAllText(@"D:\Main Stuff\CSharp\Solutions\HelloWorldCSharp\Yo.txt","Yo");
            File.AppendAllText(@"D:\Main Stuff\CSharp\Solutions\HelloWorldCSharp\Yo1.txt","Yo1");
            File.Copy(@"D:\Main Stuff\CSharp\Solutions\HelloWorldCSharp\Yo.txt", @"D:\Main Stuff\CSharp\Solutions\HelloWorldCSharp\Yo1.txt",true);
            File.Replace(@"D:\Main Stuff\CSharp\Solutions\HelloWorldCSharp\Yo.txt", @"D:\Main Stuff\CSharp\Solutions\HelloWorldCSharp\Yo1.txt", @"D:\Main Stuff\CSharp\Solutions\HelloWorldCSharp\Yo2.txt");



            //To (sort of) streamline the whole process of file handling, we can use a streamreader and a
            //streamwriter.
            //A stream reader and writer are the exact equivalents of the <filevariable>.reader and
            //<filevariable>.writer objects in python. They basically open a file either to be written to
            //or read depending on which one you use. More on this in the AdvancedFileHandling file.

        }
    }
}