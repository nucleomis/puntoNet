/*
 1.17. Crear un proyecto llamado “PalabraMasLongitud” para ingresar por teclado una
cadena que tenga 3 palabras y mostrar la longitud de la que tenga más longitud.
 */

using System;

namespace PalabraMasLongitudCs
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase, palabra1, palabra2, palabra3;

            Console.Write("ingrese 3 palabras: ");
            frase = Console.ReadLine();

            palabra1 = frase.Substring(0,frase.IndexOf(" "));

            palabra2 = frase.Substring(frase.IndexOf(" ")+1);
            palabra2 = palabra2.Substring(0,palabra2.IndexOf(" "));

            palabra3 = frase.Substring(frase.LastIndexOf(" ")+1);

            Console.WriteLine("la primer palabra tiene una longitud de: "+palabra1.Length);
            Console.WriteLine("la segunda palabra tiene una longitud de: " + palabra2.Length);
            Console.WriteLine("la tercer palabra tiene una longitud de: " + palabra3.Length);

            int mayor = Math.Max(palabra1.Length, palabra2.Length);

            mayor = Math.Max(mayor, palabra3.Length);

            Console.WriteLine("la mayor longitud es: " + mayor);
        }
    }
}
