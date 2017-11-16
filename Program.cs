using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace kontrolnay_eliseev
{
    class Cell
    {
        char[,] mass = new char[12, 12];
        Random rand = new Random();
        public void ce1l()
        {
                Console.ForegroundColor = ConsoleColor.Blue;
                for (int i = 0; i < 13; i++)
                {
                    Console.Write("__");
                }
                Console.ResetColor();
                Console.WriteLine();
                int g = rand.Next(1, 12);
                int f = rand.Next(1, 12);

                for (int i = 0; i < 12; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("|");
                    Console.ResetColor();
                    for (int j = 0; j < 12; j++)
                    {
                        mass[i, j] = Convert.ToChar(rand.Next(0, 2));
                        if (i == f && j == g)
                        {
                            mass[i, j] = '@';
                        }
                        if (mass[i, j] == 1 || mass[i, j] == 2)
                        {
                            mass[i, j] = '#';
                        }
                        Console.Write(mass[i, j] + "-");
                    }
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("|");
                    Console.ResetColor();
                }
                for (int i = 0; i < 13; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("__");
                    Console.ResetColor();
                }
                Console.WriteLine();
                Console.WriteLine("@ = персонаж");
                Console.WriteLine("# = препятствия");
                Console.WriteLine("- = пустая клетка");
        }

        class Program
        {
            static void Main(string[] args)
            {
                Cell cell = new Cell();
                cell.ce1l();
            }
        }
    }
}

