/*
 3.1. Crear un proyecto llamado “Media” y un módulo que permita cargar 5 números en un
arreglo de 5 elementos; calcular la media y luego imprimir cada elemento del arreglo y la
desviación que tiene respecto a la media. La MEDIA se obtiene la sumatoria de los todos
elementos del arreglo y se divide por la cantidad de estos. La DESVIACION de cada
elemento se obtiene restándole al elemento la MEDIA.
 */
using System;

namespace MediaCs
{
    class Program
    {
        static void Main(string[] args)
        {
            CargaMedia();
        }
        static void CargaMedia()
        {
            int acum = 0;
            int []numeros = new int[5];

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("ingrese el numero: ");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
                acum += numeros[i];
            }
            acum = acum / 5;

            Console.WriteLine("el promedio es: " + acum);
    
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("la desviacion del numero " + numeros[i] + " es: "+(numeros[i]-acum));
            }
        }
    }
}
