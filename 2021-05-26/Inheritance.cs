using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            double r = 3.0, h = 5.0;
          
            Shape c = new Circle(r);
            Shape s = new Sphere(r);
            Shape l = new Cylinder(r,h);
            Shape squ = new Square(r, h);

            Console.WriteLine("Area of Circle = {0:F2}", c.Area());
            Console.WriteLine("Area of Circle = {0:F2}", s.Area());
            Console.WriteLine("Area of Circle = {0:F2}", l.Area());
            Console.WriteLine("Area of Circle = {0:F2}", squ.Area());
        }
        public class Shape
        {
            public const double PI = Math.PI;
            protected double x, y;

            public Shape()
            {

            }

            public Shape(double x,double y)
            {
                this.x = x;
                this.y = y;
            }

            public virtual double Area()
            {
                return x * y;
            }

        }
        
        public class Circle : Shape 
        {
            public Circle(double r):base(r,0)
            {

            }

            public override double Area()
            {
                return PI * x * x;                
            }
        }

        class Sphere : Shape
        {
            public Sphere(double r) : base(r, 0) 
            {
            }

            public override double Area()
            {
                return 4 * PI * x * x;
            }

        }

        class Cylinder : Shape 
        {
            public Cylinder(double r ,double h):base(r,h)
            {

            }

            public override double Area()
            {
                return 2 * PI * x * x + 2 * PI * x * y;
            }
        }

        class Square : Shape
        {
            public Square(double r, double h) : base(r, h)
            {

            }

            public override double Area()
            {
                return x * y;
            }
        }
    }
}
