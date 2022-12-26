using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    public class DirectoriesandPaths
    {

        //PATH


        /*
        The path class is an abstract class that performs operations on String instances that contain file
        or directory path information. These operations are performed in a cross-platform manner.
         
        A path is a string that provides the location of a file or directory. A path can contain absolute 
        or relative location information. Absolute paths fully specify a location: the file or directory 
        can be uniquely identified regardless of the current location. Relative paths specify a partial 
        location: the current location is used as the starting point when locating a file specified with a 
        relative path.
        
        eg of absolute path: D:\Main Stuff\CSharp\Solutions\HelloWorldCSharp
        eg of relative path: Yo1.txt
         
        In members that accept a path as an input string, that path must be well-formed or an exception is 
        raised. For example, if a path is fully qualified but begins with a space, the path is not trimmed 
        in methods of the class. Therefore, the path is malformed and an exception is raised. Similarly, a 
        path or a combination of paths cannot be fully qualified twice. For example, "c:\temp c:\windows" 
        also raises an exception in most cases. Ensure that your paths are well-formed when using methods 
        that accept a path string.          
         */

        //METHODS

        //NOTE: ALL OF THESE METHODS ARE PATH.<METHOD>

        /*
        METHOD                                      EXPLANATION
         
        ChangeExtension(<path>, String? Extension)	        Changes the extension of a path string.

        Combine(<path1>, <path2>, ...)	            Combines multiple strings into a path. Functions the same as
                                                    concatenating each string together with a \ in between them.

        Combine(String[])	                        Combines an array of strings into a path.         
         
        GetDirectoryName(<path>)	                Returns the directory information for the specified 
                                                    path.

        GetExtension(<path>)	                    Returns the extension (including the period ".") of the
                                                    specified path string.         

        GetFileName(<path>)	                        Returns the characters after the last directory separator 
                                                    character in path. If the last character of path is a 
                                                    directory or volume separator character, this method returns 
                                                    Empty. If path is null, this method returns null.

        GetFileNameWithoutExtension(<path>)	        Returns the file name of the specified path string 
                                                    without the extension.
         
        GetFullPath(<path>)	                        Returns the absolute path for the specified path string.

        GetInvalidFileNameChars()	                Gets an array containing the characters that are not 
                                                    allowed in file names.

        GetInvalidPathChars()	                    Gets an array containing the characters that are not 
                                                    allowed in path names.

        GetRandomFileName()	                        Returns a random folder name or file name.

        GetTempFileName()	                        Creates a uniquely named, zero-byte temporary .tmp file on 
                                                    disk and returns the full path of that file.

        GetTempPath()	                            Returns the path of the current user's temporary folder.

        HasExtension(<path>)                        Determines whether a path includes a file name 
                                                    extension.

        EndsInDirectorySeparator(<path>)	        Returns a value that indicates whether the specified path ends
                                                    in a directory separator.

        TrimEndingDirectorySeparator(<path>)	    Trims one trailing directory separator beyond the root 
                                                    of the specified path.  

        Join(<path>, <path>, <path>, ...)	        Concatenates two or more paths into a single path.

        Join(String[])	                            Concatenates an array of paths into a single path.

         */

        //Difference between Path.Combine and Path.Join:

        //Unlike the Combine method, the Join method does not attempt to root the returned path.
        //That is, if path2 is an absolute path, the Join method does not discard the previous paths as the
        //Combine method does.

        //    Concatenating  'C:/Program Files/' and 'Utilities/SystemUtilities'
        //       Path.Join:     'C:/Program Files/Utilities/SystemUtilities'
        //       Path.Combine:  'C:/Program Files/Utilities/SystemUtilities'
        //
        //    Concatenating  'C:/' and '/Program Files'
        //       Path.Join:     'C://Program Files'
        //       Path.Combine:  '/Program Files'
        //
        //    Concatenating  'C:/Users/Public/Documents/' and 'C:/Users/User1/Documents/Financial/'
        //       Path.Join:     'C:/Users/Public/Documents/C:/Users/User1/Documents/Financial/'
        //       Path.Combine:  'C:/Users/User1/Documents/Financial/'


        //DIRECTORY


        /*FROM MICROSOFT DOCUMENTATION:

       Use the Directory class for typical operations such as copying, moving, renaming, creating, and 
       deleting directories.        
        */

        //METHODS:                                      Explanation

        //NOTE: All of these methods are Directory.<method>.

        //CreateDirectory(string <path>)	            Creates all directories and subdirectories in
        //                                              the specified path unless they already exist.

        //GetCurrentDirectory()	                        Gets the current working directory of the application.

        //SetCurrentDirectory(<path>)	                Sets the application's current working directory to the
        //                                              specified directory.

        //Exists(<path>)	                            Determines whether the given path refers to an existing
        //                                              directory on disk.

        //GetParent(<path>)                             Retrieves the parent directory of the specified path,
        //                                              including both absolute and relative paths.

        //Move(<path>, <path>)                          Moves a file or a directory and its contents to a new
        //                                              location.

        //Delete(<path>)	                            Deletes an empty directory from a specified path.

        //Delete(<path>, Boolean)                       Deletes the specified directory and, if indicated, any
        //                                              subdirectories and files in the directory.

        //EnumerateDirectories(<path>)	                Returns an enumerable collection of directory full names
        //                                              in a specified path.

        //EnumerateDirectories(<path>, string <SearchPattern>)  Returns an enumerable collection of directory
        //                                              full names that match a search pattern in a specified path.
        //                                              The SearchPattern string matches against the names of
        //                                              directories in path. This parameter can contain a
        //                                              combination of valid literal path and wildcard (* and ?)
        //                                              characters, but it doesn't support regular expressions.

        //EnumerateDirectories (<path>, <SearchPattern>, System.IO.SearchOption <SearchOption>) Returns an
        //                                              enumerable collection of directory full names that match a
        //                                              search pattern in a specified path, and optionally
        //                                              searches subdirectories. The SearchOption variable has
        //                                              2 options: SearchOption.AllDirectories,
        //                                              SearchOption.TopDirectoryOnly.

        //EnumerateFiles(<path>)	                    Returns an enumerable collection of full file names in a 
        //                                              specified path.

        //EnumerateFiles(<path>, <SearchPattern>)	    Returns an enumerable collection of full file names that 
        //                                              match a search pattern in a specified path.         

        //EnumerateFiles(<path>, <SearchPattern>, SearchOption) Returns an enumerable collection of full file names
        //                                              that match a search pattern in a specified path, and
        //                                              optionally searches subdirectories.	

        //GetCreationTime(<path>)                       Gets the creation date and time of a directory.

        //GetCreationTimeUtc(<path>)                    Gets the creation date and time, in Coordinated Universal
        //                                              Time(UTC) format, of a directory.

        //SetCreationTime(<path>, DateTime <creationTime>)      Sets the creation date and time for the specified
        //                                              file or directory.

        //GetDirectories(<path>)                        Returns the names of subdirectories(including their paths)
        //                                              in the specified directory.

        //GetDirectories(<path>, <SearchPattern>)       Returns the names of subdirectories(including their paths)
        //                                              that match the specified search pattern in the specified
        //                                              directory.

        //GetFiles(String)	                            Returns the names of files(including their paths) in the
        //                                              specified directory.

        //GetLastAccessTime(<path>)	                    Returns the date and time the specified file or directory
        //                                              was last accessed.

        //SetLastAccessTime(<path>, DateTime <creationTime>)        Sets the date and time the specified file or
        //                                              directory was last accessed.

        //GetLastWriteTime(<path>)	                    Returns the date and time the specified file or directory
        //                                              was last written to.

        //SetLastWriteTime(<path>, DateTime <creationTime>)     Sets the date and time a directory was last written
        //                                              to.



        //NOTE: !!THESE ARE NOT ALL THE METHODS, IN PARTICULAR THE GET<X> METHODS ALL HAVE OVERLOADS THAT ALLOW
        //US TO SEARCH SUBDIRECTORIES AND CHOOSE ENUMERATION OPTIONS. I DID NOT PUT THEM HERE DUE TO LENGTH!!
    }
}
