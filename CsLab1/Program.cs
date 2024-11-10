using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Converter;

namespace CsLab1
{
    public class Program
    {
        static void Main(string[] args)
        {
            CsvToHtml.Convert("C:\\Users\\kamil\\source\\repos\\CsLaby\\CsLab1\\test_file.csv", "C:\\Users\\kamil\\source\\repos\\CsLaby\\CsLab1\\html_test.html");
        }
    }
}

