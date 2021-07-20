/*
 2.8. Crear un proyecto “Deposito” para resolver el siguiente planteo: se deposita un capital a un
plazo de 6 meses, con una tasa de interés de anual (%), que se ingresa por teclado,
capitalizable cada mes, es decir, se suman los intereses ganados al capital.
• Elaborar un algoritmo que, a partir del capital inicial y la cantidad de meses imprima un
reporte como el siguiente ejemplo que tiene una tasa anual del 36%:

• Implementar el algoritmo en una función que devuelve el interés en pesos (Interés $) y
recibe el capital$, interés anual %
• Implementar una subrutina para mostrar cada línea del reporte, esta recibe: mes, capital
$ e interés $
• Ambos métodos descriptos anteriormente se tienen que invocar tantas veces como
meses especificados. Evitar la repetición de código con el uso correcto de métodos.
 */

using System;

namespace DepositoCs
{
    class Program
    {
        static void Main(string[] args)
        {
            float interes, deposito, d;

            Console.Write("ingrese el deposito inicial: ");
            deposito = Convert.ToSingle(Console.ReadLine());

            Console.Write("ingrese el interes mensual: ");
            interes = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("mes\tcapital\tinteres\tsaldo");

            d = deposito;

            Intereses(1,ref deposito, interes);
            Intereses(2,ref deposito, interes);
            Intereses(3,ref deposito, interes);
            Intereses(4,ref deposito, interes);
            Intereses(5,ref deposito, interes);
            Intereses(6,ref deposito, interes);

            Console.WriteLine("interese anual en pesos: "+InteresAnual(d, interes));
        }

        static void SumaInteres(ref float monto, float interes)
        {
            monto += interes;
        }

        static void Intereses(int mes, ref float monto, float interes)
        {
            Console.WriteLine(mes+"\t"+monto+"\t"+(monto*interes/100)+"\t"+(monto+interes));
            SumaInteres(ref monto, interes);
        }
 /*• Implementar el algoritmo en una función que devuelve el interés en pesos (Interés $) y
recibe el capital$, interés anual %
 */
        static float InteresAnual(float capital, float interes_anual)
        {
            return capital *(interes_anual/100)*12;
        }
    }
}
