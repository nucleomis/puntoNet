Imports System

Module Program
    Sub Main(args As String())
        Dim frase1 = "Aunque la cadena sea de oro, sirve para lo mismo.", palabra1, palabra2 As String
        frase1 = frase1.ToLower()

        Console.WriteLine("dentro de la frase: " & frase1)
        Console.Write(Chr(10) & "ingrese una palabra dentro de la frase: ")

        palabra1 = Console.ReadLine()

        Console.Write(Chr(10) & "Para reemplazarla por la palabra: " & Chr(10))
        palabra2 = Console.ReadLine()

        Console.WriteLine("resultado: " & Chr(10))
        Console.WriteLine(frase1.Replace(palabra1, palabra2))
    End Sub
End Module
