/*
 2.1. Crear un proyecto llamado “Hipotenusa” que implemente una función que reciba el tamaño
de los lados A y B, calcule y devuelva C (hipotenusa). Dados los lados A y B de un triángulo
rectángulo, según el teorema de Pitágoras, el cuadrado de la hipotenusa (C), es igual a la
suma del cuadrado de los catetos (lados) de lo que se da la siguiente fórmula: c² = a² + b².
Ingresar los valores por teclado y mostrar el resultado en consola. 
 */
using System;

namespace HipotenusaCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Hipotenusa(3,4));
        }
        static double Hipotenusa(double a, double b)
        {
            double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
            return c;
        }
    }
}
