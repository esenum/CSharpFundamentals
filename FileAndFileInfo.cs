using System.IO;

namespace Fundamentals
{
    internal class FileAndFileInfo
    {
        static void Main(string[] args)
        {
            var path1 = @"c:\Users\HP\Downloads\1.png";
            var path2 = @"c:\Users\HP\Downloads\second.png";


            File.Copy(@"c:\Users\HP\Downloads\third.png", @"c:\Users\HP\Desktop\third.png");
            File.Delete(path2);

            if(File.Exists(path1))
            {
                //...
            }

            var content=File.ReadAllText(path1);

            var fileInfo=new FileInfo(path1);
            fileInfo.CopyTo(@"c:\Users\HP\Desktop\Zoom\New");
            fileInfo.Delete();

            if(fileInfo.Exists)
            {
                //...
            }
        }
    }
}
