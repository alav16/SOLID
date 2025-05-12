/*
    public class Shape
    {
        public string Type { get; set; }
    }

    public class AreaCalculator
    {
        public double CalculateArea(Shape shape)
        {
            if (shape.Type == "Circle")
            {
                return 3.14 * 5 * 5;
            }
            else if (shape.Type == "Square")
            {
                return 5 * 5;
            }
            else
            {
                throw new Exception("Shap is invalid");
            }
        }
    }
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace prob3
{
    public abstract class Shape
    {
        public abstract double CalcArea();
    }

    public class Circle : Shape
    {
        public double Radius {  get; set; }

        public override double CalcArea()
        {
            return Math.PI * Radius * Radius;
        }
    }

    public class Square : Shape
    {
        public double Side { get; set; }

        public override double CalcArea()
        {
            return Side * Side;
        }
    }

    public class AreaCalc
    {
        public double CalcArea(Shape shape)
        {
            return shape.CalcArea();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            var circle = new Circle { Radius = 5 };
            var square = new Square { Side = 4};

            var calc = new AreaCalc();

            Console.WriteLine($"{calc.CalcArea(circle)}");
            Console.WriteLine($"{calc.CalcArea(square)}");
        }
    }
}
