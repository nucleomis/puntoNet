Imports System

Module Program
    Sub Main(args As String())
        Dim frase, palabra1, palabra2, palabra3 As String

        Console.Write("ingrese 3 palabras: ")
        frase = Console.ReadLine()

        palabra1 = frase.Substring(0, frase.IndexOf(" "))

        palabra2 = frase.Substring(frase.IndexOf(" ") + 1)
        palabra2 = palabra2.Substring(0, palabra2.IndexOf(" "))

        palabra3 = frase.Substring(frase.LastIndexOf(" ") + 1)

        Console.WriteLine("la primer palabra tiene una longitud de: " & palabra1.Length)
        Console.WriteLine("la segunda palabra tiene una longitud de: " & palabra2.Length)
        Console.WriteLine("la tercer palabra tiene una longitud de: " & palabra3.Length)

        Dim mayor = Math.Max(palabra1.Length, palabra2.Length)

        mayor = Math.Max(mayor, palabra3.Length)

        Console.WriteLine("la mayor longitud es: " & mayor)
    End Sub
End Module
