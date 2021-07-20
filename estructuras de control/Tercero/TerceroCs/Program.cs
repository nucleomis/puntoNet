/*
 Crear un proyecto “Tercero” para resolver con IF: ingresar 5 valores enteros e
informar cual es el mayor por su posición de ingreso, por ejemplo, dado los siguientes
valores: 3,7,12,5,9 informar: “El tercer número es el mayor valor”.

 */
using System;

namespace TerceroCs
{
    class Program
    {
        public static void  Ingreso()
        {
            ushort i;
            ushort[] numeros = new ushort[5];

            for (i = 0; i < numeros.Length; i++)
            {
                Console.Write("ingrese el valor " + (i + 1) + " : ");
                numeros[i] = Convert.ToUInt16(Console.ReadLine());
            }

            Mayor(ref numeros);
        }

        public static void Mayor(ref ushort[] valor)
        {
            ushort mayor = valor[0], posicion=0;

            for (ushort i = 1; i < valor.Length - 1; i++)
            {
                if (mayor < valor[i + 1])
                {
                    mayor = valor[i + 1];
                    posicion = (ushort)(i + 2);
                }
            }
            ushort[] resultado = new ushort[]{ mayor, posicion};

            string pos = Posicion(resultado[1]);

            Console.WriteLine("el mayor es: " + mayor + " y esta en la " + pos + " posicion");
        }

        public static string Posicion(ushort posicion)
        {
            string pos = "";
            switch (posicion)
            {
                case 1:
                    pos = "primera";
                    break;
                case 2:
                    pos = "segunda";
                    break;
                case 3:
                    pos = "tercera";
                    break;
                case 4:
                    pos = "cuarta";
                    break;
                case 5:
                    pos = "quinta";
                    break;
            }
            return pos;
        }

        static void Main(string[] args)
        {

            Ingreso();
            
        }
    }
}
