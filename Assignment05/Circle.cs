using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    internal class Circle : ICircle
    {
        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;
        }

        public double Area
        {
            get
            {
                return Math.PI * radius * radius;
            }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle: Radius = {radius}, Area = {Area:F2}");
            //F2: Fixed-point format with 2 decimal places.
        }
    }
}
