/*
 3.2. Crear un proyecto llamado “Ventas” y un módulo que cuenta con tres vectores cargados
programáticamente referente a productos: el primero tiene el código, el segundo el nombre y
el tercero el precio unitario.

• Repetitivamente se ingresa un código de producto y el programa muestra su descripción
y precio, si el código no existe mostrar un mensaje de error.

• Luego el usuario ingresa la cantidad con lo que el programa responde calculando el total
de venta por ese producto y el total general (acumulado los productos anteriores).

• Se repite el proceso hasta que el código sea cero.
 */
using System;
using System.Linq;//llamo a esta libreria para poder usar Enumerable

namespace VentasCs
{
    class Program
    {
        static void Main(string[] args)
        {
            ushort[] codigo = {1,2,27}, cant = {0,0,0};
            string[] nombre = { "tomate", "lechuga", "huevo" };
            double[] precio = { 12.5, 16.30, 10 };

            Proceso(codigo, nombre, precio, cant);
        }
        //---------------------------------------------------------------------------------------------
        //procesa el toda la logica: imputs y ouputs
        static void Proceso(ushort[] codigo, string[] nombre, double[] precio, ushort[] cant)
        {
            double[] subtotal = { 0, 0, 0 };
            double total = 0;
            ushort cantidad = 0, valor = 1;

            while (valor != 0)
            {
                Console.Write("ingrese el codigo del producto: ");
                valor = Convert.ToUInt16(Console.ReadLine());
                var check = Array.Exists(codigo, x => x == valor);//verifico si existe dentro del array codigo el valor buscado
                if (check == true && valor != 0)
                {//si el valor es correcto y existe, me muestra en pantalla un detalle, solicitando la cantidad a comprar del producto
                    Detalle(nombre, codigo, precio, valor, ref cantidad,ref subtotal,ref cant, ref total);
                }
                else if (check == false && valor != 0)
                {//si el codigo de producto no existe y no se deseo cerrar el programa se muestra un mensaje de error
                    Console.WriteLine("error! codigo no encontrado");
                }
                else
                {//sino el resultado es 0 y el programa se finaliza listo para mostrar el resultado de la operacion
                    Console.WriteLine("----programa finalizado----\npresione ENTER para salir");
                    Console.ReadLine();
                    Console.Clear();
                    break;
                }
            }
            //una vez finalizada todo el pedido, se procede a mostrar el resultado de la operacion
            Mostrar(codigo, subtotal, nombre, cant, total);
        }
        //-------------------------------------------------------------------------------------------------------
        //muestro el detalle del producto y suma las cantidades, total gral y subtotales pedidos
        static void Detalle(string[] nombre, ushort[]codigo, double[]precio, ushort valor, ref ushort cantidad, ref double[]subtotal, ref ushort[]cant, ref double total )
        {
            Console.WriteLine("\t----Descripcion del producto:----");
            Console.WriteLine("Nombre: " + nombre[Array.FindIndex(codigo, x => x == valor)]);//FindIndex devuelve la posicion donde encuentra el valor buscado
            Console.WriteLine("Precio: " + precio[Array.FindIndex(codigo, x => x == valor)] + "\n");
            Console.Write("ingrese la cantidad: ");
            //valores ref:
            cantidad = Convert.ToUInt16(Console.ReadLine());
            subtotal[Array.FindIndex(codigo, x => x == valor)] += precio[Array.FindIndex(codigo, x => x == valor)] * cantidad;
            cant[Array.FindIndex(codigo, x => x == valor)] += cantidad;
            total += precio[Array.FindIndex(codigo, x => x == valor)] * cantidad;
        }
        //---------------------------------------------------------------------------------------------------------
        //imprime un listado detallado de los productos con el codigo, nombre, cantidad, subtotal y un total general
        static void Mostrar(ushort[] codigo, double[]subtotal, string[] nombre ,ushort[]cant,double total )
        {
            Console.WriteLine("cod\tdescripcion\tcant\tsubttotal");
            for (int i = 0; i < codigo.Length; i++)
            {
                if (subtotal[i] != 0)
                {
                    Console.WriteLine(codigo[i] + "\t" + nombre[i] + string.Concat(Enumerable.Repeat(" ", 16 - (nombre[i].Length))) + cant[i] + "\t" + subtotal[i]);
                }
            }
            Console.WriteLine("total: " + total);
        }
    }
}