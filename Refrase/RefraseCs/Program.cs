/*
Crear un proyecto “Refrase” que ingrese por teclado dos palabras, la primera palabra,
que debe existir en la frase “Aunque la cadena sea de oro, sirve para lo mismo.” Será
reemplazada por la segunda dentro de la frase. La palabra que es reemplazada es reconocida
dentro de la frase porque esta precedida de un espacio y seguida de un espacio, de una coma
o de un punto. Mostrar el resultado.

*/

using System;

namespace RefraseCs
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase1 = "Aunque la cadena sea de oro, sirve para lo mismo.", palabra1, palabra2;
            Console.Write("ingrese la palabra dentro de la frase: ");
            palabra1 = Console.ReadLine();

            Console.Write("ingrese la palabra para reemplazarla: ");
            palabra2 = Console.ReadLine();

            Console.WriteLine(frase1.Replace(palabra1, palabra2));
        }
    }
}
