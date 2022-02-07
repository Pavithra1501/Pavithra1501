using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Real_number
    {
        static void Main(string[] args)
        {
            double avg = 0, avg1 = 0;
            double sum = 0, sum1 = 0;
            int a;
            Console.WriteLine("enter a  number");
            for (int i = 1; i <=5; i++)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a > 0)
                {
                    sum = sum + a;
                }
                else
                {
                    sum1 = sum1 - a;
                }
            }
            avg = sum / 10;
            avg1 = sum1 / 10;
            Console.WriteLine("sum of positive numbers:" + sum);
            Console.WriteLine("sum of negative numbers:" + sum1);
            Console.WriteLine("avg of positive numbers:" + avg);
            Console.WriteLine("avg of negative numbers:" + avg1);
        }
    }
}


    






       
        
    

