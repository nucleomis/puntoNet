Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, c As Integer

        Console.Write("ingrese el primer parametro: ")
        a = Console.ReadLine()

        Console.Write("ingrese el segundo parametro: ")
        b = Console.ReadLine()

        Console.Write("ingrese el tercer parametro: ")
        c = Console.ReadLine()

        Console.WriteLine("cuadrado: " & Superficie(a))

        Console.WriteLine("rectangulo: " & Superficie(a, b))

        Console.WriteLine("trapecio: " & Superficie(a, b, c))
    End Sub

    Function Superficie(val As Integer)

        Return val * val
    End Function

    Function Superficie(val1 As Integer, val2 As Integer)

        Return val1 * val2
    End Function

    Function Superficie(val1 As Integer, val2 As Integer, val3 As Integer)

        Return (val1 + val2) / 2 * val3
    End Function
End Module
