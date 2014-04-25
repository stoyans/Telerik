using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FindAllExeInWindowsFolder
{
    class Program
    {

       static void DFSFolders(string root)
       {
           string[] dirList = Directory.GetDirectories(root);

           foreach (var file in Directory.GetFiles(root))
           {
               if (file.EndsWith(".exe"))
               {
                   Console.WriteLine(file);
               }
           }

           foreach (var dir in dirList)
           {
               DFSFolders(dir);
           }
       }

        static void Main()
        {
            string root = @"C:\Program Files";

            DFSFolders(root);
        }
    }
}
