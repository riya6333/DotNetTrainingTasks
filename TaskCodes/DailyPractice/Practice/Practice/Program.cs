using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first name : ");
            string firstName = Console.ReadLine();
            Console.Write("Enter the last name : ");
            string lastName = Console.ReadLine();
            Console.WriteLine("My name is {0} {1}", firstName, lastName);
            Console.ReadLine();
            Days.DaysRecognition();
        }
    }
}
