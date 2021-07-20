/*
 2.23. Crear un proyecto “ParesImpares” Utilizando la estructura de repetición más adecuada
elaborar un programa que se ingresen valores enteros hasta que se ingrese cero (descartar negativos).
Luego informar cuantos son pares y cuantos impares. Si todos son pares o todos
son impares informar esta situación particular en lugar de la leyenda anterior.

 */
using System;

namespace ParesImparesCs
{
    class Program
    {
        static void Main(string[] args)
        {
            LecturaParesImpares();
        }

        static void LecturaParesImpares()
        {
            int numero;
            int pares = 0;
            int impares = 0;
            Console.WriteLine("para salir presione 0");
            Console.Write("ingrese el numero positivo: ");
            numero = Convert.ToInt32(Console.ReadLine());
            while (numero!=0)
            {
                Console.Write("ingrese el numero: ");
                numero = Convert.ToInt32(Console.ReadLine());
                if (numero>0)
                {
                    if (numero % 2 == 0)
                    {
                        pares += 1;
                    }
                    else
                    {
                        impares += 1;
                    }
                }
            }
            Console.WriteLine("la cantidad de numeros pares son: " + pares);
            Console.WriteLine("la cantidad de numeros impares son: " + impares);
            if (impares == 0)
            {
                Console.WriteLine("TODOS SON PARES!!");
            }
            else if (pares == 0)
            {
                Console.WriteLine("TODOS SON IMPARES!!");

            }
        }
    }
}
