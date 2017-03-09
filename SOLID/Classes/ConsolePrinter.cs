using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Classes
{
    class ConsolePrinter : IPrinter
    {
        public void PrintValue(double value)
        {
            Console.WriteLine(value);
        }
    }
}
