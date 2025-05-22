using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hafteh
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter an integer number to show you the day of the week(1 <= DAy <= 7) --->");
                int Day = Convert.ToInt32(Console.ReadLine());
                if (Day == 0)
                {
                    break;
                }
                switch (Day)
                {
                    case 1:
                        {
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("Shanbe");
                            Console.ResetColor();
                            break;
                        }
                    case 2:
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("yekShanbe");
                            Console.ResetColor();
                            break;
                        }
                    case 3:
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("doShanbe");
                            Console.ResetColor();
                            break;
                        }
                    case 4:
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.WriteLine("seShanbe");
                            Console.ResetColor();
                            break;
                        }
                    case 5:
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("charShanbe");
                            Console.ResetColor();
                            break;
                        }
                    case 6:
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("panjShanbe");
                            Console.ResetColor();
                            break;
                        }
                    case 7:
                        {
                            Console.ForegroundColor = ConsoleColor.Gray;
                            Console.WriteLine("Jome");
                            Console.ResetColor();
                            break;
                        }
                    default:
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error...\nyour number must be in range of (1,7)");
                            Console.ResetColor();
                            break;
                        }
                }
            }
        }
    }
}
