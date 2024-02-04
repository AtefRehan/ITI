using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lab6
{
    internal class Program
    {

        //public static float CalcAllArea(Shape[] _shapes)
        //{
        //    float result = 0;
        //    for (int i = 0; i < _shapes.Length; i++)
        //    {

        //        if (_shapes[i].GetType() == typeof(Circle))
        //        {
        //            result += ((Circle)_shapes[i]).CalcArea();
        //        }
        //        else if (_shapes[i].GetType() == typeof(Rectangle))
        //        {
        //            result += ((Rectangle)_shapes[i]).CalcArea();
        //        }
        //        else if (_shapes[i].GetType() == typeof(Triangle))
        //        {
        //            result += ((Triangle)_shapes[i]).CalcArea();
        //        }
        //        else if (_shapes[i].GetType() == typeof(Square))
        //        {
        //            result += ((Square)_shapes[i]).CalcArea();
        //        }
        //    }

        //    return result;
        //}

        //public static float CalcAllArea(Shape[] _shapes)
        //{
        //    float result = 0;

        //    for (int i = 0; i < _shapes.Length; i++)
        //    {
        //        if (_shapes[i].GetType() == typeof(Square))
        //        {
        //            result += ((Square)_shapes[i]).CalcArea();
        //        }
        //        if (_shapes[i].GetType() == typeof(Circle))
        //        {
        //            result += ((Circle)_shapes[i]).CalcArea();
        //        }
        //        if (_shapes[i].GetType() == typeof(Rectangle))
        //        {

        //            result += ((Rectangle)_shapes[i]).CalcArea();
        //        }
        //        if (_shapes[i].GetType() == typeof(Triangle))
        //        {
        //            result += ((Triangle)_shapes[i]).CalcArea();
        //        }
        //    }
        //    return result;
        //}

        //public static string RunAllDraw(Shape[] _shapes)
        //{
        //    string color="";
        //    for(int i=0; i< _shapes.Length;i++)
        //    {
        //        if (_shapes[i].GetType() == typeof(Circle))
        //        {
        //            color += ((Circle)_shapes[i]).Color;
        //        }
        //        if (_shapes[i].GetType() == typeof(Triangle))
        //        {
        //            color += ((Triangle)_shapes[i]).Color;
        //        }
        //        if (_shapes[i].GetType() == typeof(Rectangle))
        //        {
        //            color += ((Rectangle)_shapes[i]).Color;
        //        }
        //        if (_shapes[i].GetType() == typeof(Square))
        //        {
        //            color += ((Square)_shapes[i]).Color;
        //        }

        //    }
        //    return color;

        //}

        public static string RunAllDraw(Shape[] _shapes)
        {
            string color = "";
            for (int i = 0; i < _shapes.Length; i++)
            {
             color += _shapes[i].Color;

            }
            return color;

        }

        public static float CalcAllArea(Shape[] _shapes)
        {
            float result = 0;

            for (int i = 0; i < _shapes.Length; i++)
            {
                result += _shapes[i].CalcArea();
            }
            return result;
        }



        static void Main(string[] args)
        {

            Circle circle = new Circle(5);
            Rectangle rectangle = new Rectangle(5,3);
            Square square = new Square();
            Triangle triangle = new Triangle(2, 3, 4);
            Shape[] shapes = new Shape[] { circle, rectangle, square, triangle };


            Console.WriteLine(CalcAllArea(shapes));
            Console.WriteLine(RunAllDraw(shapes));

        }
    }
   }

