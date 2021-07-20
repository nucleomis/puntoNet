/*
 2.7. Crear un proyecto llamado “FechaInteligente” para obtener una fecha con la menos
información posible. Existen 3 posibilidades:
• Se suministra un valor que representa un día del mes y se completa el mes y año con los
actuales.
• Se suministra dos valores que representa un día del mes, el mes y se completa con el año
actual.
• Se suministra tres valores que representa un día del mes, el mes y año
• Demostrar las 3 operaciones invocándolas desde el main.
 */
using System;

namespace FechaInteligenteCs
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.Write("ingrese el primer dato: ");
            a = Convert.ToInt32(Console.ReadLine());

            Console.Write("ingrese el segundo dato: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.Write("ingrese el tercer dato: ");
            c = Convert.ToInt32(Console.ReadLine());

            Fecha(a);
            Fecha(a, b);
            Fecha(a, b, c);
        }

        static void Fecha(int a)
        {
            DateTime f = DateTime.Now;
            Console.WriteLine(a+"/"+ f.ToString("MM/yyyy"));
        }

        static void Fecha(int a,int b)
        {
            DateTime f = DateTime.Now;
            Console.WriteLine(a + "/" + b +"/"+ f.ToString("/yyyy"));
        }

        static void Fecha(int a,int b, int c)
        {
            DateTime f = new DateTime(c,b,a);
            Console.WriteLine(f.ToString("dd/MM/yyyy"));
        }
    }
}
