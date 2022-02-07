using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class sumofevenandodd
    {
        static void Main()
        {
            sumofevenandodds();

        }
         static void sumofevenandodds()
        {
            int evennum = 0;
            int oddnum = 0;
            int[] arr = new int[10];
            for ( int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"enter the number{i + 1}");
                arr[i] = int.Parse(Console.ReadLine());
            }
            foreach (int j in arr)
            {
                if (j % 2 == 0)
                {
                    evennum = j + evennum;
                }
                else
                {
                    oddnum = j + oddnum;
                }
            }
            Console.WriteLine($"evennum is {evennum}");
            Console.WriteLine($"oddnum is {oddnum}");

                }
                }
            }

           
                


    

