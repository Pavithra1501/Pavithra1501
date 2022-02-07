using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        { 
                Console.WriteLine(" Enter the degree celsium:");
                int c = Convert.ToInt32(Console.ReadLine());
                int k = c + 273;
                int f = c * 18 / 10 + 32;
                Console.WriteLine("the kelvin degree is:" + k);
                Console.WriteLine("the celsius degree is:" + c);
                Console.WriteLine("the faherenhit degree is:" + f);
                Console.ReadLine();


            }
        }
    }

    

