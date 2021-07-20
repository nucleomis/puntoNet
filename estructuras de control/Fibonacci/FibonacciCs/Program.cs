/*
 2.19. Crear un proyecto “Fibonacci” para elaborar “Los números de Fibonacci”, estos
constituyen una secuencia que empieza con 0 y 1; el número que sigue a éstos se calcula
sumando los dos anteriores y así sucesivamente. Utilizando la estructura de repetición más
adecuada elaborar un algoritmo que imprima los 20 primeros números de la secuencia.
 */
using System;

namespace FibonacciCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci();
        }

        static void Fibonacci()
        {
            for (short i = 0, b = 1; i < 20; i+= b, b += i)
            {
                Console.WriteLine(i);
                Console.WriteLine(b);
            }

        }
    }
}
