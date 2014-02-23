using System;
using System.Collections.Generic;

namespace _1.Point3D
{
    public struct Point3D
    {
        private int PointX;
        private int PointY;
        private int PointZ;
        static readonly Point3D pointO;
                           
        public Point3D(int x, int y, int z)
        {
            this.PointX = x;
            this.PointY = y;
            this.PointZ = z;
        }

        public int X
        {
            get 
            {
                return this.PointX;
            }
            set
            {
                this.PointX = value;
            }
        }
        public int Y
        {
            get
            {
                return this.PointY;
            }
            set
            {
                this.PointY = value;
            }
        }
        public int Z
        {
            get
            {
                return this.PointZ;
            }
            set
            {
                this.PointZ = value;
            }
        }

        static Point3D()
        {
            pointO = new Point3D(0, 0, 0);
        }

        public static Point3D PointO
        {
            get
            {
                return pointO;
            }
        }

        public override string ToString()
        {
            return string.Format("Coordinates of the point are: X = {0}, Y = {1}, Z = {2}", this.PointX, this.PointY, this.PointZ);
        }

    }
}
