/*
 1.20. Crear un proyecto llamado “FinDeAño” que informe el tiempo restante del momento
actual hasta fin de año en: meses, semanas y horas. Debe funcionar en cualquier año.
 */
using System;

namespace FinDeAñoCs
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime fecha_actual = DateTime.Now;
            DateTime fin_de_año = new DateTime(fecha_actual.Year,12,31);

            TimeSpan diferencia = fin_de_año - fecha_actual;

            int dias = diferencia.Days;

            Console.WriteLine(dias);
        }
    }
}
