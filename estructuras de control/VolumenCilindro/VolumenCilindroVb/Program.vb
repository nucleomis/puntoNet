Imports System

Module Program
    Sub Main(args As String())
        Dim radio, altura As Double
        Console.Write("ingrese el radio de la base: ")
        radio = Console.ReadLine()

        Console.Write("ingrese la altura: ")
        altura = Console.ReadLine()

        Console.WriteLine(Volumen(radio, altura))
    End Sub

    Function Volumen(r As Double, h As Double)
        Return Math.Round(Math.PI * Math.Pow(r, 2) * h, 2)
    End Function
End Module
