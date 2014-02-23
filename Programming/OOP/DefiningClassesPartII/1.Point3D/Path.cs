using System;
using System.Collections.Generic;

namespace _1.Point3D
{
    class Path
    {
        private List<Point3D> pathOfPoints;

        public Path()
        {
            pathOfPoints = new List<Point3D>();
        }
        public List<Point3D> PathOfPoints
        {
            get { return pathOfPoints; }
        }

        public void AddPoint(Point3D point)
        {
            pathOfPoints.Add(point);
        }
        
    }
}
