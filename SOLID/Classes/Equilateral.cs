using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Classes
{
    class Equilateral : Triangle
    {
        public Equilateral(IPrinter printer)
            : base(printer)
        {

        }
        public override void GetAllSides()
        {
            _printer.PrintValue(Base);
            _printer.PrintValue(Base);
            _printer.PrintValue(Base);
        }
    }
}
