/*
 2.2. Crear un proyecto llamado “VolumenCilindro” que implemente una función que lea el radio
de la base y la altura de un cilindro y que calcule y devuelva el volumen. El volumen de un
cilindro se calcula multiplicando la constante Pi (π=3.14159265) por el cuadrado del radio
de la base(r) por la altura(h) de lo que se da la siguiente fórmula: v = πr²h. Ingresar los
valores por teclado y mostrar el resultado en consola. 
 */
using System;

namespace VolumenCilindroCs
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio, altura;
            Console.Write("ingrese el radio de la base: ");
            radio = Convert.ToDouble(Console.ReadLine());

            Console.Write("ingrese la altura: ");
            altura = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine(Volumen(radio,altura));
        }

        static double Volumen(double r, double h)
        {
            return Math.Round(Math.PI * Math.Pow(r, 2) * h, 2);
        }
    }
}
