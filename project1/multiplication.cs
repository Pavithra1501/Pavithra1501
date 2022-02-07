using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class multiplication
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter the number:");
                int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            while(i<=10)
            {
                int x = n * i;
                Console.WriteLine(n+ "*" +i +"="+x);
                i++;
                Console.ReadLine();
            }
        }
    }
}
