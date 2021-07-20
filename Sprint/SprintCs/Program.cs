/*
 Crear un proyecto llamado “Sprint” que se ingrese una fecha y hora dato por dato y
además un número de horas. Mostrar como resultado la fecha hora obtenida de sumar la
cantidad de horas a la fecha hora ingresada
 */
using System;

namespace SprintCs
{
    class Program
    {
        static void Main(string[] args)
        {
            int año, mes, dia;
            double cantidad_horas, horas = 0;

            Console.Write("ingrese el año: ");
            año = Convert.ToInt32(Console.ReadLine());

            Console.Write("ingrese el mes: ");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.Write("ingrese el dia: ");
            dia = Convert.ToInt32(Console.ReadLine());

            Console.Write("ingrese la cantidad de horas a sumar: ");
            cantidad_horas = Convert.ToDouble(Console.ReadLine());

            DateTime fecha = new DateTime();

            fecha = fecha.AddYears(año-1);
            fecha = fecha.AddMonths(mes-1);
            fecha = fecha.AddDays(dia-1);

            Console.WriteLine("\nagregando las horas: " + fecha);

            fecha = fecha.AddSeconds(cantidad_horas * 3600);

            Console.WriteLine("\nla fecha resultante es: "+fecha);
        }

    }
}
