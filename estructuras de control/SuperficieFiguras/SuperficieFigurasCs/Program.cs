/*
 2.6. Crear un proyecto llamado “SuperficieFiguras” para calcular la superficie de una figura. Los
valores se ingresan por consola Usar una función sobrecargada para resolver el área y según
el número de parámetros será:
1 cuadrado = lado*lado
2 rectangulo = base * altura
3 trapecio = (Base mayor+base menor)/2*altura
 */
using System;

namespace SuperficieFigurasCs
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("ingrese el primer parametro: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("ingrese el segundo parametro: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("ingrese el tercer parametro: ");
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("cuadrado: "+ Superficie(a));

            Console.WriteLine("rectangulo: "+ Superficie(a, b));

            Console.WriteLine("trapecio: "+ Superficie( a, b, c));
        }

        static double Superficie(int val)
        {
            return val * val;
        }

        static double Superficie(int val1, int val2)
        {
            return val1 * val2;
        }

        static double Superficie(int val1, int val2, int val3)
        {
            return (val1 + val2)/ 2 * val3;
        }

    }
}
