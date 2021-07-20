/*
 2.22. Crear un proyecto llamado “Acumuladora” que implemente una subrutina que recibe
un valor decimal y lo va acumulando. Invocar por lo menos tres veces la subrutina desde el
main y mostrar luego de cada llamada mostrar el valor acumulado.

 */
using System;

namespace AcumuladoraCs
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal acum = 0.12m;

            Console.WriteLine(acum);
            Acumular(ref acum);
            Console.WriteLine(acum);
            Acumular(ref acum);
            Console.WriteLine(acum);
            Acumular(ref acum);

            Console.WriteLine(acum);

        }
        static void Acumular(ref decimal acumulador)
        {
            acumulador += acumulador;
        }
    }
}
