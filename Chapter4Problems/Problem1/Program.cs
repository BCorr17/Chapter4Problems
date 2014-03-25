using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problem1
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            string input;
            int n;
            while (true)
            {
                Console.Write("input number here:");
                input = Console.ReadLine();
                n = Convert.ToInt32(input);
                if (input == "999")
                {
                    break;
                }
                if (n < 999)
                {
                    sum += n;
                }
                Console.WriteLine("Sum is {0}", sum);

                 
            }
        }
    }
}
