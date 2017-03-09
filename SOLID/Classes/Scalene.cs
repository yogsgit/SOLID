using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Classes
{
    class Scalene : Triangle, IRightTriangle
    {
        public Scalene(IPrinter printer)
            : base(printer)
        {

        }
        public bool IsRightAngledTriangle { get; set; }
        public override void GetAllSides()
        {
            //assuming base length is different 
            // the other 2 sides
            _printer.PrintValue(Base);
            CalculateHypotenuse(Height, Base / 2);
            CalculateHypotenuse(Height, Base / 2);
        }
        public void CalculateHypotenuse
            (double side1, double side2)
        {
            _printer.PrintValue(Math.Sqrt(
                    side1 * side1 + side2 * side2));
        }
    }
}
