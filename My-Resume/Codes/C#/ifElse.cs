using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ifElse
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer nummber --->");
            int Number = Convert.ToInt32(Console.ReadLine());
            if (Number < 0)
            {
                Console.WriteLine(-Number);
            }
            else
            {
                Console.WriteLine(Number);
            }
        }
    }
}
