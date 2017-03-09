using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Classes
{
    class Circle : ICircle
    {
        public double Radius { get; set; }
        private readonly IPrinter _printer;
        public Circle(IPrinter printer)
        {
            _printer = printer;
        }
        public void CalculateArea()
        {
            _printer.PrintValue(
                3.14f * Radius * Radius);
        }
        public void CalculateCircumference()
        {
            _printer.PrintValue(
                3.14f * 2 * Radius);
        }
    }
}
