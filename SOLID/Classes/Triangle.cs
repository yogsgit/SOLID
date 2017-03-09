using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Classes
{
    abstract class Triangle : IShapes
    {
        public double Height { get; set; }
        public double Base { get; set; }
        protected readonly IPrinter _printer;
        public Triangle(IPrinter printer)
        {
            _printer = printer;
        }
        public void CalculateArea()
        {
            _printer.PrintValue
                  ((Height * Base) / 2);
        }

        public abstract void GetAllSides();
    }
}
