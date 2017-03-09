using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Classes
{
    class FilePrinter : IPrinter
    {
        private readonly IWriter _writer;
        public FilePrinter(IWriter writer)
        {
            _writer = writer;
        }
        public void PrintValue(double value)
        {
            _writer.WriteValue(value.ToString());
        }
    }
}
