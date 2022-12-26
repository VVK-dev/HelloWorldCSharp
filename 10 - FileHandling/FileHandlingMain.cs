using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandling
{
    public class FileHandlingMain
    {
        public static void Main(string[] args)
        {
            string path = @"D:\Main Stuff\CSharp\Solutions\HelloWorldCSharp\Yo1.txt";

            //Creating a FileStream

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate, FileAccess.ReadWrite))
            {
                //Creating a StreamReader and StreamWriter

                using (StreamReader sr = new StreamReader(fs))
                {
                    Console.WriteLine(sr.Read());
                    Console.WriteLine(sr.Peek());
                }

                //We can use the using keyword this way also:

                using StreamWriter sw = new(fs);
                sw.WriteLine("Yoyo");

                fs.Close();
            }

            using (StreamReader sr1 = new(File.Open(path, FileMode.OpenOrCreate)))
            {
                Console.Write(sr1.ReadToEnd());
                sr1.Close();
            }

        }
    }
}
