using System;

namespace FuncionesCs
{
    class Program
    {
        static void Main(string[] args)
        {
            Resultado(Sumar(15, 32, 64));
        }

        public static int Sumar (int sumar1, int sunar2)
        {
            return sumar1 + sunar2;
        }

        static int Sumar(int sumar1, int sumar2,int sumar3) //metodo
        {
            return sumar1 + sumar2 + sumar3;        }

        static void Resultado(int resul) //procedimiento
        {
            Console.WriteLine(resul);
        }

        int Calculo(int numero1,int numero2)//funcion
        {
            int suma = numero1 + numero2;

            return suma;
        }
    }
}
