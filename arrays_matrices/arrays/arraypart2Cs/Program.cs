using System;

namespace arraypart2Cs
{
    class Program
    {
        static void Main(string[] args)
        {
            var nombres = new String[4];
            Console.WriteLine("ingrese: ");

            for (int i = 0; i < 4; i++)
            {
                nombres[i] = Console.ReadLine();
            }

            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine(nombres[i]);
            }
        }
    }
}
