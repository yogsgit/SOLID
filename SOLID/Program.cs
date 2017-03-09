using SOLID.Classes;
using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            string outputPath = "c:\\temp\\temp.txt";
            IPrinter printer;
            IWriter fileWriter = new FileWriter(outputPath);

            printer = new ConsolePrinter();
            IShapes circle = new Circle(printer) { Radius = 5 };
            circle.CalculateArea();

            printer = new FilePrinter(fileWriter);
            Triangle triangle = new Scalene(printer) { Base = 6, Height = 4 };
            triangle.GetAllSides();
        }
    }
}
