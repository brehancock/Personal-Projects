using System.Drawing;

namespace Project2Project
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point a = new Point(-5, 6);
            Point b = new Point(5, 4, 6);
            Point c = new Point(a);
            Point d = new Point(true);
            Point e = new Point(false);
            c.Transform(-2, -1, 3);
            b.Copy(d);
            a.Z = 7.8;
            Console.WriteLine("a: " + a);
            Console.WriteLine("b: " + b);
            Console.WriteLine("c: " + c);
            Console.WriteLine("d: " + d);
            Console.WriteLine("e: " + e);
            Console.WriteLine("Distance a-b = " + a.GetDistance(b));
            Console.WriteLine("Distance d-b = " + d.GetDistance(b));
            Console.WriteLine("Distance c-(2,3,4) = " + c.GetDistance(2, 3, 4));
            Console.WriteLine("a==b?: " + a.IsEqual(b));
            Console.WriteLine("b==d?: " + b.IsEqual(d));
            d.Z = 3.4;
            Console.WriteLine("d: " + d);
            Console.WriteLine("b==d?: " + b.IsEqual(d));
            Console.WriteLine("b==(5,4,3)?: " + b.IsEqual(5, 4, 3));
            Console.WriteLine("b==(5,4)?: " + b.IsEqual(5, 4));
            Console.WriteLine("a==(-5,6,10)?: " + a.IsEqual(-5, 6, 10));
            Console.WriteLine("a==(-5,6)?: " + a.IsEqual(-5, 6));
            Console.WriteLine("c==a?: " + c.IsEqual(a));
            Console.WriteLine("is e origin? : " + e.IsOrigin());
            e.Transform(b);
            Console.WriteLine("e: " + e);
            e.Transform(a);
            Console.WriteLine("e: " + e);
            e.Convert2D();
            Console.WriteLine("e: " + e);
            e.Convert3D(2.3);
            Console.WriteLine("e: " + e);
            e.Convert3D(5.2);
            Console.WriteLine("e: " + e);
        }
    }
}