using System;

namespace arraypart3
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] lista = new ushort[3];

            for (ushort i = 0; i < lista.Length; i++)
            {
                lista[i] = i;
            }

            iterar(lista);
        }

        private static void iterar (ushort[] lista)
        {
            foreach (var contenido in lista)
            {
                Console.WriteLine(contenido);
            }
        }
    }
}
