Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine(Multiplicacion(2, 2))
        Console.WriteLine(Multiplicacion(2, 2, 4))
        Console.WriteLine(Multiplicacion(2, 2, 4, 2))
    End Sub

    Function Multiplicacion(val1 As Double, val2 As Double)

        Return val1 * val2
    End Function

    Function Multiplicacion(val1 As Double, val2 As Double, val3 As Double)
        Return Multiplicacion(val1, val2) * val3
    End Function

    Function Multiplicacion(val1 As Double, val2 As Double, val3 As Double, val4 As Double)
        Return Multiplicacion(val1, val2, val3) * val4
    End Function
End Module
