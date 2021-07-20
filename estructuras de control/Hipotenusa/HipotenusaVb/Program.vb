Imports System

Module Program
    Sub Main(args As String())

        Dim dato1, dato2 As Double
        Console.Write("ingrese el primer valor: ")
        dato1 = Console.ReadLine()

        Console.Write("ingrese el segundo dato: ")
        dato2 = Console.ReadLine()

        Console.WriteLine(Hipotenusa(dato1, dato2))
    End Sub

    Function Hipotenusa(a As Double, b As Double)
        Dim c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2))
        Return c
    End Function
End Module
