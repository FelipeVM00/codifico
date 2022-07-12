using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Models
{
    abstract class Shape
    {
        public double height = 0.0;
        public double width = 0.0;
        public double radius = 0.0;

        public Shape(double width, double height)
        {
            this.height = height;
            this.width = width;
        }

        public Shape(double radius)
        {
            this.radius = radius;
        }

        public virtual void PrintArea()
        {
            Console.Clear();
            double area = Math.PI * Math.Pow(radius, 2);
            Console.WriteLine("El área de la figura es: {0}", area);
        }
    }
}
