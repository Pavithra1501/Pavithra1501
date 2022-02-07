using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class toupperandlower
    {
        static void Main()
        {
            //Console.Write("Enter name file: ");
            string name = @"C:\Users\Pavithra R\source\repos\project1\project1\TextFile1.txt";
            if (File.Exists(name))
            {
                StreamReader fileRw = File.OpenText(name);
                StreamWriter fileWr = File.CreateText(name + "uppercase" + ".csv");
                string line;
                do
                {
                    line = fileRw.ReadLine();
                    if (line != null)
                        fileWr.WriteLine(line.ToUpper());
                }
                while (line != null);
                fileRw.Close();
                fileWr.Close();
                if (File.Exists(name + "uppercase" + ".csv"))
                    Console.WriteLine("Conversion successful!");
                Console.ReadLine();
            }
        }
    }
}

