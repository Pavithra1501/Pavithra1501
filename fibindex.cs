using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class fibindex
    {

        static void fibonacci(int index)
        {
            int temp1 = 0;
            int temp2 = 1;
            int vallndex = 0;
            if (index == 1)
            {
                Console.WriteLine(1);
            }
            else
            {
                for (int i = 2; i <= index; ++i)
                {
                    vallndex = temp1 + temp2;
                    temp1 += temp2;
                }
                    Console.WriteLine(index);
                    Console.WriteLine(vallndex);
                    return;
                }
            }
            static void Main(string[] args)
            {
                fibonacci(2);

            }
        }
    }
    
            
    





    



