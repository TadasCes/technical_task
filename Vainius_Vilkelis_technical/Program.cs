using System;

namespace Vainius_Vilkelis_technical
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());

            Console.Clear();
            for (int i = 1; i <= h; i++)
            {
                for (int j = 1; j <= h - i; j++)
                {
                    Console.Write(" ");
                }
                for (int o = 1; o <= i; o++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }

        }
    }
}
