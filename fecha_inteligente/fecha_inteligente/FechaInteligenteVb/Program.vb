Imports System

Module Program
    Sub Main(args As String())
        Dim a, b, c As Integer

        Console.Write("ingrese el primer dato: ")
        a = Console.ReadLine()

        Console.Write("ingrese el segundo dato: ")
        b = Console.ReadLine()

        Console.Write("ingrese el tercer dato: ")
        c = Console.ReadLine()

        Fecha(a)
        Fecha(a, b)
        Fecha(a, b, c)
    End Sub

    Sub Fecha(a As Integer)
        Dim f = DateTime.Now
        Console.WriteLine(a & "/" & f.ToString("MM/yyyy"))
    End Sub

    Sub Fecha(a As Integer, b As Integer)
        Dim f = DateTime.Now
        Console.WriteLine(a & "/" & b & "/" & f.ToString("/yyyy"))
    End Sub

    Sub Fecha(a As Integer, b As Integer, c As Integer)
        Dim f = New DateTime(c, b, a)
        Console.WriteLine(f.ToString("dd/MM/yyyy"))
    End Sub
End Module
