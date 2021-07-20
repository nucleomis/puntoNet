using System;

namespace ArraysCs
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = NuevoArray();
            for (int i = 0; i < a.Length; i++)
            {
                Console.WriteLine(a[i]);
            }
        }

        static ushort[] NuevoArray()
        {
            var valores = new ushort[3];

            valores[0] = 5;
            valores[1] = 15;
            valores[2] = 25;
            return valores;
        }
    }
}
