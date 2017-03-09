using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Classes
{
    class Rectangle : IShapes
    {
        public double Length { get; set; }
        public double Breadth { get; set; }
        private readonly IPrinter _printer;
        public Rectangle(IPrinter printer)
        {
            _printer = printer;
        }
        public void CalculateArea()
        {
            _printer
                .PrintValue(Length * Breadth);
        }
    }
}
