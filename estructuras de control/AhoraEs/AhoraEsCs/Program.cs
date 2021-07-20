/*
 2.3. Crear un proyecto llamado “AhoraEs” que imprima la fecha y hora actual con sus
respectivas leyendas según los siguientes requerimientos:
• Utilizar una subrutina para imprimir la fecha actual.
• Utilizar una función para obtener la hora actual.
• Llamar a los procedimientos desde el principal. 
 */

using System;

namespace AhoraEsCs
{
    class Program
    {
        static void Main(string[] args)
        {
            FechaActual();
            Console.WriteLine(HoraActual());
        }

        static void FechaActual()
        {
            Console.WriteLine("fecha actual: "+DateTime.Now);
        }

        static string HoraActual()
        {
            DateTime fecha = DateTime.Now;
            return "hora actual: "+fecha.ToString("hh:mm;ss");
        }
    }
}
