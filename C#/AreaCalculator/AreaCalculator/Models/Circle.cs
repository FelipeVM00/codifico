using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator.Models
{
    class Circle : Shape
    {
        public Circle(double radius) : base(radius) {
            if (radius < 0 || radius > double.MaxValue)
                throw new Exception("El radio está fuera de rango");
        }
    }
}
