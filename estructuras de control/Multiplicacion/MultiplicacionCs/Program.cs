/*
 2.5. Crear un proyecto llamado “Multiplicación” que implementa una función sobrecargada
capaz de multiplicar dos, tres y cuatro valores de acuerdo al número de argumentos que
recibe. Invocarla desde el módulo main probando las diferentes alternativas y mostrando los
resultados por consola. Ej.: multiplicar(5, 8). Minimizar la repetición de código.
 */

using System;

namespace MultiplicacionCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiplicacion(2, 2));
            Console.WriteLine(Multiplicacion(2, 2, 4));
            Console.WriteLine(Multiplicacion(2, 2, 4, 2));

        }

        static double Multiplicacion(double val1, double val2)
        {
            return val1 * val2;
        }

        static double Multiplicacion(double val1, double val2, double val3)
        {
            return Multiplicacion(val1,val2)*val3;
        }

        static double Multiplicacion(double val1, double val2, double val3, double val4)
        {
            return Multiplicacion(val1,val2,val3) * val4;
        }

    }
}
