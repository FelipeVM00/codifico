using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Models
{
    internal class Rectangle : Shape
    {
        public Rectangle(double width, double height) : base(width, height) {
            if (width < 0 || width > double.MaxValue)
                throw new Exception("La base esta fuera de rango");
            if (height < 0 || height > double.MaxValue)
                throw new Exception("La altura esta fuera de rango");
        }
        public override void PrintArea()
        {
            double area = height * width;
            Console.Clear();
            Console.WriteLine("El área del rectángulo es: {0}", area);
        }
    }
}
