using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Calender
    {
        static int year = new int();
        static int month = new int();
        static int[,] calendar = new int[6, 7];
        private static DateTime date;

        static void Draw()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("\t", month);
            Console.WriteLine("MON TU WED THU FRI SAT SUN");

        }

        static void FillCalendar()
        {
            int days = DateTime.DaysInMonth(year, month);
            int currentDay = 1;
            var dayOfWeek = (int)date.DayOfWeek;
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1) && currentDay - dayOfWeek + 1 <= days; j++)
                {
                    if (i == 0 && month > j)
                    {
                        calendar[i, j] = 0;
                    }
                    else
                    {
                        calendar[i, j] = currentDay - dayOfWeek + 1;
                        currentDay++;
                    }
                }
            }
        }

        static void DrawCalendar()
        {
            for (int i = 0; i < calendar.GetLength(0); i++)
            {
                for (int j = 0; j < calendar.GetLength(1); j++)
                {
                    if (calendar[i, j] > 0)
                    {
                        if (calendar[i, j] < 10)
                        {
                            Console.Write(" " + calendar[i, j] + " ");
                        }
                        else
                        {
                            Console.Write(calendar[i, j] + " ");
                        }
                    }
                    else
                    {
                        Console.Write("  ");
                    }
                }
                Console.WriteLine(" ");
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Enter the year:");
            year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the month : ");
            month = Convert.ToInt32(Console.ReadLine());

            Draw();
            FillCalendar();
            DrawCalendar();

        }
    }
}







