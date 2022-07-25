using System;
using System.IO;

namespace Fundamentals
{
    internal class PathStudy
    {
        public static void Main(string[] args)
        {
            var path = @"c:\Users\HP\Desktop\Fundamentals\Fundamentals.sln";

            var dotIndex=path.IndexOf('.');
            var extension=path.Substring(dotIndex);

            Console.WriteLine("Extension: "+Path.GetExtension(path));
            Console.WriteLine("File Name: " + Path.GetFileName(path));
            Console.WriteLine("File Name without Extension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("Directory Name: " + Path.GetDirectoryName(path));

        }
    }
}
