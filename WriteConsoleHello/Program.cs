using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WriteConsoleHello
{
     class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" ");
            for (int i = 0; i < 38; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine("");
            Console.WriteLine("");

            for (int s = 0; s < 5; s++)
            {
                for (int i = 0; i < 37; i++)
                {
                    if (i >= 1 && i <= 4 || i >= 6 && i <= 7 || i >= 13 && i <= 14 || i >= 16 && i <= 22 || i >= 24 && i <= 30)
                    {
                        if (s == 2 && i >= 1 && i <= 5 || s == 4 && i >= 15 && i <= 20 || s == 4 && i >= 23 && i <= 28)
                        {
                            Console.Write("*");
                        }
                        else
                        {

                            Console.Write(" ");
                        }
                    }
                    else
                    {
                        if (s == 1 && i >= 9 && i <= 13 || s == 3 && i >= 9 && i <= 13 || s == 1 && i >= 32 && i <= 35 || s == 2 && i >= 32 && i <= 35 || s == 3 && i >= 32 && i <= 35)
                        {
                            Console.Write(" ");
                        }
                        else
                        {
                            Console.Write("*");
                        }
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine(" ");
            for (int i = 0; i < 38; i++)
            {
                Console.Write("*");
            }
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
