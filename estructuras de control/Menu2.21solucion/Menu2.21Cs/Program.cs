/*
 2.17. Crear un proyecto “Menu” donde existe un menú para acceder a diferentes programas
y donde los elementos de este estén almacenados en una enumeración.
• Mostrar todas las opciones del menú
• Permitir elegir una
• Mostrar la opción seleccionada

2.21. A la consigna 2.17 agregar un elemento a la enumeración llamado “Salir” y de valor
0. Envolver el menú en una estructura iterativa donde va a permitir elegir opciones hasta que
se ingrese el valor de “Salir”
 */
using System;

namespace Menu2._21Cs
{
    class Program //PRINCIPAL
    {
        static void Main(string[] args)
        {
            ProcesoMenu(); 
        }
    /*======================funciones m v c ===========================*/
        static void MenuPantalla()//muestro la pantalla de opciones (VISTA)
        {
            Console.WriteLine("1- opcion1\n2-opcion2\n3-opcion3\n0-salir");

        }
        static void ProcesoMenu()//proceso el las salidas, ingresos y retornos (MODELO)
        {
            short opcion = 1;
            while (opcion!=0)
            {
                MenuPantalla();
                Console.Write("opcion: ");
                opcion = Convert.ToInt16(Console.ReadLine());
                MostrarResultado(opcion);
            }
            
        }
        static void MostrarResultado(short opcion) //segun el dato recibido proceso una salida (CONTROLADOR)
        {
            if (opcion!=0 && opcion <=3 &&opcion>0)
            {
                Console.WriteLine("usted a seleccionado la opcion: " + opcion);
                Console.WriteLine("PRESIONE ENTER PARA CONTINUAR");
                Console.ReadLine();
                Console.Clear();
            }
            else if (opcion < 0 || opcion > 3)
            {
                Console.Clear();
                Console.WriteLine("ERROR, el dato ingresado no es correcto\ningrese nuevamente: ");
            }
            else
            {
                Console.Clear();
                Console.WriteLine("usted a seleccionado la opcion: " + opcion+" saliendo del sistema");
            }
        }
    }
}
