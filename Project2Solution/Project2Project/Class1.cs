using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project2Project
{
    internal class Point
    {
        private double x;
        public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        private double y;
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        private double z;
        public double Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }

        private bool is2D;
        public bool Is2d
        {
            get
            {
                return is2D;
            }
            set
            {
                is2D = value;
            }
        }
       
        public Point(bool flag2D)
        {

            x = 0;
            y = 0;
            z = 0;
            if (flag2D == true)
            {
                is2D = true;
               

            }
            else
            {
                is2D = false;
                

            }
        }

        public Point(Point pt)
        {
            is2D = pt.is2D;
            x = pt.x;
            y = pt.y;
            z = pt.z;

        }

        public Point(double x_, double y_, double z_)
        {
            is2D = false;
            x = x_;
            y = y_;
            z = z_;
         
        }

        public Point(double x_, double y_)
        {
            x = x_;
            y = y_;
            z = 0;
            is2D = true;
        }

        public void Convert2D()
        {
            is2D = true;
            z = 0;
        }

        public void Convert3D(double z_)
        {
            if (is2D == true)
            {
                is2D = false;
                z = z_;
            }

        }
        public double GetDistance(Point pt)
        {
            double distance;
            if (is2D == true || pt.is2D == true)
            {
                double x_ = pt.x;
                double y_ = pt.y;
                x_ = x - x_;
                y_ = y - y_;
                distance = x_ * x_ + y_ * y_;
                distance = Math.Sqrt(distance);
            }
            else
            {
                double x_ = pt.x;
                double y_ = pt.y;
                double z_ = pt.z;
                x_ = x - x_;
                y_ = y - y_;
                z_ = z - z_;
                distance = x_ * x_ + y_ * y_ + z_ * z_;
                distance = Math.Sqrt(distance);
            }

            return distance;
        }
        public double GetDistance(double x_, double y_, double z_)
        {
            double distance;
            if (is2D == false)
            {
                
                x_ = x - x_;
                y_ = y - y_;
                z_ = z - z_;
                distance = x_ * x_ + y_ * y_ + z_ * z_;
                distance = Math.Sqrt(distance);
                return distance;
            }
            else
            {
                x_ = x - x_;
                y_ = y - y_;
                
                distance = x_ * x_ + y_ * y_;
                distance = Math.Sqrt(distance);
                return distance;
            }
        }

        public void Transform(Point pt)
        {
            if (is2D == true || pt.is2D == true)
            {
                x += pt.x;
                y += pt.y;
            }
            else
            {
                x += pt.x;
                y += pt.y;
                z += pt.z;
            }
        }

        public void Transform(double x_, double y_, double z_)
        {
            if (is2D == true)
            {
                x += x_;
                y += y_;
            }
            else
            {
                x += x_;
                y += y_;
                z += z_;
            }
        }

        public bool IsEqual(Point pt)
        {

            if (x==pt.x && y==pt.y&&z==pt.z)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsEqual(double x_, double y_, double z_)
        {
            if (is2D == true)
            {
                return false;
            }
            else if (x == x_ && y == y_ && z == z_)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsEqual(double x_, double y_)
        {
            if (is2D == false)
            {
                return false;
            }
            else if (x == x_ && y == y_)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool IsOrigin()
        {
            if (x==0 && y==0 &&z==0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public void Copy(Point pt)
        {
            pt.is2D = is2D;
            pt.x=x ;
            pt.y=y ;
            pt.z=z ;

        }
        public override string ToString()
        {
            if (is2D == true)
            {
                return $"({x}, {y})";
            }
            else
            {
                return $"({x}, {y}, {z})";
            }
        }
    }
}
