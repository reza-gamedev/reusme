using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RP5
{
    class Program
    {
        static void Main(string[] args)
        {
            int Num1 = 0;
            int Num2 = 0;
            try
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please Enter Number 1 :");
                Console.ResetColor();
                Num1 = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Please Enter Number 2 :");
                Console.ResetColor();
                Num2 = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Please Just Enter Number...");
                Console.ResetColor();
            }
            catch
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Unknown Error...");
                Console.ResetColor();
            }
            finally
            {

            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("sum is : " + (Num1 + Num2));
            Console.ResetColor();
        }
    }
}
