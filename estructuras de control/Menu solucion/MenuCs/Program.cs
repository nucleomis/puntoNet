/*
 2.17. Crear un proyecto “Menu” donde existe un menú para acceder a diferentes programas
y donde los elementos de este estén almacenados en una enumeración.
• Mostrar todas las opciones del menú
• Permitir elegir una
• Mostrar la opción seleccionada
 */
using System;

namespace MenuCs
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcesoMenu();
        }

        static void MenuPantalla()
        {
            Console.WriteLine("1- opcion1\n2-opcion2\n3-opcion3");
            
        }
        static void ProcesoMenu()
        {
            MenuPantalla();
            Console.Write("opcion: ");
            MostrarResultado(Convert.ToInt16(Console.ReadLine()));
        }

        static void MostrarResultado(short opcion)
        {
            Console.WriteLine("usted a seleccionado la opcion: " + opcion);
        }
    }
}
