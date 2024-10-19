using System;
using System.IO;

namespace CsLab1
{
    internal class Program
    {
        private static void Write_td(string s, StreamWriter sw, bool color)
        {
            if (color)
                sw.WriteLine("<td style='background-color: gray; border-collapse: collapse;'>" + s + "</td>");
            else
                sw.WriteLine("<td style='border-collapse: collapse;'>" + s + "</td>");
        }

        private static void Write_th(string s, StreamWriter sw)
        {
            sw.WriteLine("<th>" + s + "</th>");
        }

        private static void Main(string[] args)
        {
            Console.WriteLine("Konwerter z CSV na HTML");
            var line = "";
            var path = "csvtohtml.csv";
            if (File.Exists(path))
            {
                var sr = new StreamReader(path);
                var sw = new StreamWriter("csvtohtml.html");
                sw.WriteLine("<table border ='1' style='border-collapse: collapse;'>");
                //sw.WriteLine("<tr>");
                var flag = true;
                var color = true;
                while ((line = sr.ReadLine()) != null)
                    if (flag)
                    {
                        var first = line.IndexOf(",");
                        var header = "";
                        sw.WriteLine("<tr>");
                        while (first != -1)
                        {
                            header = line.Substring(0, first);
                            line = line.Substring(first + 1);
                            Write_th(header, sw);
                            //Console.WriteLine(header);
                            //Console.WriteLine(line);
                            first = line.IndexOf(",");
                        }

                        header = line;
                        //Console.WriteLine(header);
                        Write_th(header, sw);
                        sw.WriteLine("</tr>");
                        flag = false;
                    }
                    else
                    {
                        //Console.WriteLine(line);
                        //string line = Console.ReadLine();
                        var first = line.IndexOf(",");
                        var header = "";
                        sw.WriteLine("<tr>");
                        while (first != -1)
                        {
                            header = line.Substring(0, first);
                            line = line.Substring(first + 1);
                            Write_td(header, sw, color);
                            //Console.WriteLine(header);
                            //Console.WriteLine(line);
                            first = line.IndexOf(",");
                        }

                        header = line;
                        //Console.WriteLine(header);
                        Write_td(header, sw, color);
                        sw.WriteLine("</tr>");
                        color = !color;
                    }

                sw.WriteLine("</table");


                sr.Close();
                sw.Close();
            }
        }
    }
}