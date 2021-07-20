/*
 1.10. Crea un proyecto llamado “ÁreaCirculo” donde se ingresa el radio del círculo
imprime el área. 𝐴𝑟𝑒𝑎 = 𝜋𝑟2
 */
using System;

namespace AreaCirculoCs
{
    class Program
    {
        static void Main(string[] args)
        {
            float radio;

            Console.Write("ingrese el radio del circulo: ");
            radio = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("El area del circulo es: " + Math.Round(Math.PI * Math.Pow(radio, 2),2));

        }
    }
}
