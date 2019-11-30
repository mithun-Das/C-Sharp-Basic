using System;
using System.IO;

namespace FileAndDirectory
{
    class Program
    {
        static void Main(string[] args)
        {
            /*var path = @"C:/html pdf/index.html";
            File.Copy(@"D:/html pdf/index.html", @"E:/html pdf/index.html") ;
            File.Copy(@"D:/html pdf/index.html", @"C:/html pdf/index.html");
            

            if(File.Exists(path))
            {
                File.Delete(path);
                var content = File.ReadAllText(@"E:/html pdf/index.html");
              //  Console.WriteLine(content);
                File.Copy(@"D:/html pdf/index.html", @"C:/html pdf/index.html");
            }


            var fileInfo = new FileInfo(@"E:/html pdf/index.html");
            //fileInfo.CopyTo(@"C:/index.txt");

            if(fileInfo.Exists)
            {
              //  Console.WriteLine(fileInfo);
                fileInfo.Delete();
            }

    */
            Directory.CreateDirectory(@"E:\C_SHARP_DIRECORY_TEST");

            var files = Directory.GetFiles(@"D:\academy", "*.*", SearchOption.AllDirectories);

            foreach(var file in files)
            {
                //Console.WriteLine(file);
            }

            var directories = Directory.GetDirectories(@"D:\academy", "*.*", SearchOption.AllDirectories);

            foreach(var directory in directories)
            {
                Console.WriteLine(directory);
            }

            //DirectoryInfo

            var path = @"C:/html pdf/index.html";

            Console.WriteLine(Path.GetExtension(path));
            Console.WriteLine(Path.GetFileName(path));
            Console.WriteLine(Path.GetFileNameWithoutExtension(path));
            Console.WriteLine(Path.GetDirectoryName(path));

        }
    }
}
