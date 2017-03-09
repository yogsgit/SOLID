using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Classes
{
    class Square : IShapes
    {
        public double Length { get; set; }
        private readonly IPrinter _printer;
        public Square(IPrinter printer)
        {
            _printer = printer;
        }
        public void CalculateArea()
        {
            _printer.PrintValue(Length * Length);
        }
    }
}
