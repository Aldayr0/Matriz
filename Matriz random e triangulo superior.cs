using System;

namespace ConsoleApp1321
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] n = new int[3, 3];

            //random
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Random r = new Random();
                    n[l, c] = r.Next(0, 100);
                    n[l, c] = r.Next(0, 100);


                }
            }

            //matriz
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    Console.Write(n[l, c] + " ");
                }
                Console.WriteLine("");
            }

            Console.WriteLine("\n");
            Console.WriteLine("*************");
            Console.WriteLine("Triangulo superior");
            Console.WriteLine("*************");
        
            for (int l = 0; l < 3; l++)
            {
                for (int c = 0; c < 3; c++)
                {
                    if (l < c)
                        Console.Write(n[l, c] + " ");
                    else
                        Console.Write("  ");
                }
                Console.WriteLine("");
            }
        }
    }
}