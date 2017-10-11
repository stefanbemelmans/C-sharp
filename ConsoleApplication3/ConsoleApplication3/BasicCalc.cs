using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            string yourName;
            Console.WriteLine("What is your name?");
            yourName = Console.ReadLine();
            Console.WriteLine("Hello {0}", yourName);

            do
            {
                Console.WriteLine("Enter a number: ");
                int x = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter a number: ");
                int y = Convert.ToInt32(Console.ReadLine());

                int sum = y + x;
                Console.WriteLine("The sum is {0}", sum);
            }
            while (true);
        }

    }
}
