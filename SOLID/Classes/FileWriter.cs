using SOLID.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID.Classes
{
    class FileWriter : IWriter
    {
        private readonly string _outputPath;
        public FileWriter(string outputPath)
        {
            _outputPath = outputPath;
        }
        public void WriteValue(string value)
        {
            File.AppendAllText(_outputPath, "\n" + value);
        }
    }
}
