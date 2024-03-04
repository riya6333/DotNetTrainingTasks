using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Days
    {
        public static void DaysRecognition()
        {
            Console.WriteLine(" Enter the day ");
            int day = int.Parse(Console.ReadLine());
            day %= 7;
            switch (day)
            {
                case 0:
                    Console.WriteLine("Day is Sunday");
                    break;
                case 1:
                    Console.WriteLine("Day is Monday");
                    break;
                case 2:
                    Console.WriteLine("Day is Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Day is Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Day is Thursday");
                    break;
                case 5:
                    Console.WriteLine("Day is Friday");
                    break;
                default:
                    Console.WriteLine("Day is Saturday");
                    break;

            }
            Console.ReadLine();
        }
        
    }
}
