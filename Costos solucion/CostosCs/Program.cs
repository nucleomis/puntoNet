/*
 1.9. Crear un proyecto llamado “Costos” qué calcula imprima el costo de producción de un
artículo, teniendo como datos la descripción y el número de unidades producidas. El costo se
calcula multiplicando el número de unidades producidas por un factor de costo de materiales
de 3. 5 y sumándole el producto un costo fijo de 10.700. Informar todos los datos ingresados
junto a los resultados calculados.
 */
using System;

namespace CostosCs
{
    class Program
    {
        static void Main(string[] args)
        {
            string descripcion;
            float costoFactor = 3.5F;
            int fijo = 10700, numUnidades;

            Console.Write("ingrese la descripcion del producto: ");
            descripcion = Console.ReadLine();

            Console.Write("ingrese la cantidad de unidades: ");
            numUnidades = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Producto: " + descripcion);
            Console.WriteLine("Cantidad a producir: " + numUnidades);
            Console.WriteLine("Costo total de produccion: " + ((float)((numUnidades*costoFactor)+fijo)));
        }
    }
}
