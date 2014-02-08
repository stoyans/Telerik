using System;
using System.Collections.Generic;
using System.IO;

namespace _1.Point3D
{
    static class PathStorage
    {
        public static void SavePaths(Path path)
        {
            StreamWriter savetoFile = new StreamWriter("../../paths.txt");
            using (savetoFile)
            {
                foreach (var points3D in path.PathOfPoints)
            	{
                    savetoFile.Write(points3D);
                    savetoFile.WriteLine();
	            }
                
            }          
            savetoFile.Dispose();
        }

        public static void LoadPaths()
        {
            StreamReader readfromFile = new StreamReader("../../3DPoints.txt");
            string line = string.Empty;
            Point3D loadPoint = new Point3D();

            using (readfromFile)
            {
                while ((line = readfromFile.ReadLine()) != null)
                {
                    string[] valuesOnLine = line.Split(' ');

                    loadPoint = new Point3D(int.Parse(valuesOnLine[0]), int.Parse(valuesOnLine[1]), int.Parse(valuesOnLine[2]));
                    Console.WriteLine(loadPoint.ToString());
                }
            }
 
        }

    }                               
}
