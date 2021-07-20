Imports System

Module Program
    Sub Main(args As String())
        Dim radio As Decimal

        Console.Write("ingrese el radio del circulo: ")
        radio = Console.ReadLine()

        Console.WriteLine("El area del circulo es: " & Math.Round(Math.PI * Math.Pow(radio, 2), 2))
    End Sub
End Module
