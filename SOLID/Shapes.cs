using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Shapes
    {
        public double Radius { get; set; }
        public double Height { get; set; }
        public double Base { get; set; }
        public double Length { get; set; }
        public double Breadth { get; set; }
        public void CalculateArea(string shape)
        {
            switch (shape)
            {
                case "circle":
                    Console.WriteLine(3.14f * Radius * Radius);
                    break;
                case "rectangle":
                    Console.WriteLine(Length * Breadth);
                    break;
                case "triangle":
                    Console.WriteLine((Base * Height) / 2);
                    break;
            }
        }
    }
}

