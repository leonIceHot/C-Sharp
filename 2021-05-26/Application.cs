using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Shape a = new Shape { height = 100, width = 20, x = 3, y = 5 };
            // Console.WriteLine(a.x);
            // Shape a = new Shape();

            Shape circle = new Circle();
            circle.Draw();

            Shape rectangle = new Rectangle();
            rectangle.Draw();

            Shape triangle = new Triangle();
            triangle.Draw();

            var shapes = new List<Shape>
            {
                new Circle(),
                new Rectangle(),
                new Triangle()
            };

            foreach(var shape in shapes) 
            {
                shape.Draw();
            }
        }

        public class Shape
        {
            public int x { get; private set; }

            public int y { get; private set; }

            public int height { get; set; }

            public int width { get; set; }

            public int GetX()
            {
                x = 100;
                return x;
            }

            public virtual void Draw()
            {
                WriteLine("Base class drawing ... \n");
            }


        }

        public class Circle : Shape 
        {
            public override void Draw()
            {
                WriteLine("Circle class drawing...");
                base.Draw();
            }
        }

        public class Rectangle : Shape
        {
            public override void Draw()
            {
                WriteLine("Rectangle class drawing...");
                base.Draw();
            }
        }

        public class Triangle : Shape
        {
            public override void Draw()
            {
                WriteLine("Triangle class drawing...");
                base.Draw();
            }
        }
    }
}
