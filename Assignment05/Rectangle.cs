using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment05
{
    internal class Rectangle : IRectangle
    {
        private double width;
        private double height;

        public Rectangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }

        public double Area
        {
            get
            {
                return width * height;
            }
        }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle: Width = {width}, Height = {height}, Area = {Area:F2}");
            //F2: Fixed-point format with 2 decimal places.
        }
    }
}
