using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CsLab1
{
    public class Program
    {
        static void Write_td(string s, StreamWriter sw, bool color) {
            if (color)
            {
                sw.WriteLine("<td style='background-color: gray; border-collapse: collapse;'>" + s + "</td>");
            }
            else{
                sw.WriteLine("<td style='border-collapse: collapse;'>" + s + "</td>");
            }
            
        }

        static void Write_th(string s, StreamWriter sw)
        {
            sw.WriteLine("<th>" + s + "</th>");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Konwerter z CSV na HTML");
            string line = "";
            string path = "csvtohtml.csv";
            if (File.Exists(path))
            {
                StreamReader sr = new StreamReader(path);
                StreamWriter sw = new StreamWriter("csvtohtml.html");
                sw.WriteLine("<table border ='1' style='border-collapse: collapse;'>");
                //sw.WriteLine("<tr>");
                bool flag = true;
                bool color = true;
                while ((line = sr.ReadLine()) != null)
                {
                    if (flag)
                    {
                        int first = line.IndexOf(",");
                        string header = "";
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
                        int first = line.IndexOf(",");
                        string header = "";
                        sw.WriteLine("<tr>");
                        while (first != -1)
                        {
                            header = line.Substring(0, first);
                            line = line.Substring(first + 1);
                            Write_td(header, sw,color);
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
                }
                sw.WriteLine("</table");


                sr.Close();
                sw.Close();
            }
        }
    }
}

