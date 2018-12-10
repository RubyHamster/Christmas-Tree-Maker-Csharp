using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace christmas
{
    class Program
    {
        static void makeATree(int height = 10)
        {
            Random rnd = new Random();
            int numOfSpaces = height;
            int numOfasterix = 1;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < numOfSpaces; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < numOfasterix; j++)
                {
                    if (numOfasterix == 1)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("0 ");
                        Console.ResetColor();
                    }
                    else
                    {
                        if (rnd.Next(1, 25) == 4)
                        {
                            ConsoleColor[] console = new ConsoleColor[4] { ConsoleColor.Red, ConsoleColor.Blue, ConsoleColor.Yellow, ConsoleColor.Magenta };
                            Console.ForegroundColor = console[rnd.Next(0, 4)];
                            Console.Write("o ");
                            Console.ResetColor();
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("* ");
                            Console.ResetColor();
                        }
                    }
                }
                Console.WriteLine();
                numOfasterix++;
                numOfSpaces--;
            }
        }
        static void Main(string[] args)
        {
            do
            {
                try
                {
                    makeATree(Int32.Parse(Console.ReadLine()));
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("!!!ERROR PLEASE ENTER A NUMBER!!!");
                    Console.ResetColor();
                }
            } while (true);
        }
    }
}
