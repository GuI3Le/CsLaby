using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1Core
{
    
        public class CsvToHtml
        {
            internal static string WriteTd(string s, bool color)
            {
                if (color)
                {
                    return "<td style='background-color: gray; border-collapse: collapse;'>" + s + "</td>";
                }
                return "<td style='border-collapse: collapse;'>" + s + "</td>";
            }

            internal static string WriteTh(string s)
            {
                return "<th>" + s + "</th>";
            }



            public static void Convert(string inputFile, string outputFile)
            {
                string line = "";
                if (File.Exists(inputFile))
                {
                    StreamReader sr = new StreamReader(inputFile);
                    StreamWriter sw = new StreamWriter(outputFile);
                    string tableOpening = "<table border ='1' style='border-collapse: collapse;'>";
                    string tableClosing = "</table>";
                    string trOpening = "<tr>";
                    string trClosing = "</tr>";
                    sw.WriteLine(tableOpening);
                    if ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine(trOpening);
                        string[] values = line.Split(',', ' ');
                        foreach (var element in values)
                        {
                            sw.WriteLine(WriteTh(element));
                        }

                        sw.WriteLine(trClosing);
                    }
                    int counter = 0;
                    while ((line = sr.ReadLine()) != null)
                    {
                        sw.WriteLine(trOpening);
                        string[] values = line.Split(',', ' ');
                        foreach (var element in values)
                        {
                            sw.WriteLine(WriteTd(element, (counter % 2) == 0));
                        }
                        counter++;
                        sw.WriteLine(trClosing);
                    }
                    sw.WriteLine(tableClosing);
                    sr.Close();
                    sw.Close();
                }
            }
        }
}
