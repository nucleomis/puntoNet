/*
 1.8. Crear un proyecto llamado “Cadenas” para ingresar por teclado una cadena que tenga al
menos 3 palabras y mostrar:
• La longitud de la cadena.
• La primera y la última letra.
• En qué posición aparece la primer “o”.
• Una cadena que tenga la última palabra después de la primera ingresada
 */

using System;

namespace CadenasCs
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena, primeraUltima;

            Console.Write("ingrese un texto de 3 palabras: ");
            cadena = Console.ReadLine();
            primeraUltima = (cadena[0]+""+ cadena[cadena.Length - 1]);
            Console.WriteLine("\n");

            Console.WriteLine("la longitud de la cadena es de: " + cadena.Length);
            Console.WriteLine("la primera letra es: " + primeraUltima[0]);
            Console.WriteLine("la ultima letra es: " + primeraUltima[1]);
            Console.WriteLine("si aparece la 'o': " + cadena.Contains("o"));
            Console.WriteLine("donde aparece: posicion " + cadena.IndexOf("o"));
            Console.WriteLine("Una cadena que tenga la última palabra después de la primera ingresada: " + primeraUltima);


        }
    }
}
