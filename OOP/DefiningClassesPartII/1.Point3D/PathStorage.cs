using System;
using System.Collections.Generic;
using System.IO;

namespace _1.Point3D
{
    static class PathStorage
    {
        public static void savePaths(Path path)
        {
            StreamWriter savetoFile = new StreamWriter("../../paths.txt");
            using (savetoFile)
            {
                savetoFile.Write(path.PathOfPoints);
            }
            savetoFile.Dispose();
          
        }

    }                               
}
