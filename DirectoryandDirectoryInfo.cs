using System;
using System.IO;

namespace Fundamentals
{
    //dizin(klasor) islemleri
    //For more info, take a look at : https://docs.microsoft.com/tr-tr/dotnet/api/system.io.fileinfo?view=net-6.0
    internal class DirectoryandDirectoryInfo
    {
        static void Main(string[] args)
        {
            Directory.CreateDirectory(@"c:\Users\HP\Desktop\tempDir");

            var files=Directory.GetFiles(@"c:\Users\HP\Desktop\Fundamentals","*.cs*",SearchOption.AllDirectories);
            foreach(var file in files)
                Console.WriteLine(file);

            var directories = Directory.GetDirectories(@"c:\Users\HP\Desktop\","*.*",
                SearchOption.AllDirectories);

            foreach(var directory in directories)
                Console.WriteLine(directory);

            Directory.Exists("...");

            var directoryInfo = new DirectoryInfo("...");
            directoryInfo.GetFiles();
            directoryInfo.GetDirectories();

        }
    }
}
