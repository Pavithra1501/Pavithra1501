using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class array_csv
    {
        static void Main(string[] args)
        {
            string[,] files = new string[2, 5];
            files[0, 0] = "i";
            files[0, 1] = "am";
            files[0, 2] = "pavi";
            files[0, 3] = "dfh";
            files[0, 4] = "rit";

            files[1, 0] = "abhi";
            files[1, 1] = "53";
            files[1, 2] = "67";
            files[1, 3] = "chinthamani";
            files[1, 4] = "560018";

            StreamWriter sw = File.CreateText("OutputText.csv");
            for (int i = 0; i < 2; i++)

            {
                for (int j = 0; j < 5; j++)
                {
                    sw.Write(files[i, j] + ";");

                }

                sw.Write("\n");

            }

            sw.Flush();
            sw.Close();
            Console.WriteLine("success");
        }
    }
}



