/*
 2.4. Crear un proyecto llamado “Nueva_fecha” con una función que reciba un valor fecha y un
valor entero que representa una cantidad de días y retorne a la fecha sumada la cantidad de
días. En el módulo principal ingresar una fecha y la cantidad de días, invocar a la función
creada y mostrar el valor obtenido.
 */
using System;

namespace Nueva_FechaCs
{
    class Program
    {
        static void Main(string[] args)
        {
            int mas_dias, dia,mes,año;

            Console.Write("ingrese el dia: ");
            dia = Convert.ToInt32(Console.ReadLine());

            Console.Write("ingrese el mes: ");
            mes = Convert.ToInt32(Console.ReadLine());

            Console.Write("ingrese el año: ");
            año = Convert.ToInt32(Console.ReadLine());

            DateTime fecha = new DateTime(año, mes, dia);

            Console.WriteLine("la fecha queda de la siguiente manera: " + fecha.ToString("dd/MM/yyyy"));

            Console.Write("ingrese la cantidad de dias que quiere sumar: ");

            mas_dias = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("la fecha con los la cantidad de dias sumados da como resultado: ");
            Console.WriteLine(NuevaFecha(fecha, mas_dias));
      
        }

        static string NuevaFecha(DateTime fecha, int dias)
        {
            fecha.AddDays(dias);
            return fecha.ToString("dd/MM/yyyy");
        }
    }
}
