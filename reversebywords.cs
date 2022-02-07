using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1

{
    class Reversebywords
    {
        static void Main()
        {
            reversebywords();
        }
        static void reversebywords()
        {
            Console.WriteLine("Enter the  string:");
            string s = Console.ReadLine();
            string[] words = s.Split(' ');

            for (int i = words.Length - 1; i >= 0; i--)
            {
                Console.Write(words[i] + " ");
            }
        }
    }
}
      