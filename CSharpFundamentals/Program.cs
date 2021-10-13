using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            var path = @"c:\tmp\MyFile.txt";
            
            File.Copy(@"c:\tmp\MyFile.txt", @"d:\tmp\PasteFile.txt", true);
            File.Delete(path);
            var content = File.ReadAllText(path);

            Console.WriteLine(content);

            if (File.Exists(path))
            {
                // Do something...
            }

            var fileInfo = new FileInfo(path);
            fileInfo.CopyTo("...");
            fileInfo.Delete();

            if (fileInfo.Exists)
            {
                // Do something...
            }

            Directory.CreateDirectory(@"c:\tmp\MyFolder");

            //var files = Directory.GetFiles(@"c:\projects\csharp", "*.sln", SearchOption.AllDirectories);
            //foreach(var file in files)
            //{
            //    Console.WriteLine(file);
            //}

            var directories = Directory.GetDirectories(@"c:\projects\csharp", "*.*", SearchOption.AllDirectories);
            foreach(var directory in directories)
            {
                Console.WriteLine(directory);
            }

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

            var dotIndex = path.IndexOf('.');
            var extension = path.Substring(dotIndex);

            Console.WriteLine("Extension: " + Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));
        }
    }
}
