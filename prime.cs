using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class prime
    {

        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            Boolean prime = true;
            for (int i = 2; i <= num; i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            Console.WriteLine(prime);
        }
    }
}
        
           




        
    


