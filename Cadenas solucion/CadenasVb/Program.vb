Imports System

Module Program
    Sub Main(args As String())

        Dim cadena, primeraUltima As String

        Console.Write("ingrese un texto de 3 palabras: ")
        cadena = Console.ReadLine()
        primeraUltima = (cadena(0) & "" & cadena(cadena.Length - 1))
        Console.WriteLine("\n")

        Console.WriteLine("la longitud de la cadena es de: " & cadena.Length)
        Console.WriteLine("la primera letra es: " & primeraUltima(0))
        Console.WriteLine("la ultima letra es: " & primeraUltima(1))
        Console.WriteLine("si aparece la 'o': " & cadena.Contains("o"))
        Console.WriteLine("donde aparece: posicion " & cadena.IndexOf("o"))
        Console.WriteLine("Una cadena que tenga la última palabra después de la primera ingresada: " & primeraUltima)

    End Sub
End Module
