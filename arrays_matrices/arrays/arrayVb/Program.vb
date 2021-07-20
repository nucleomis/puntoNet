Imports System

Module Program
    Sub Main(args As String())
        Dim a = Nuevo_Array()

        For index = 0 To a.Length - 1
            Console.WriteLine(a(index))
        Next

        Console.WriteLine(a(0))
        Console.WriteLine(a(1))
        Console.WriteLine(a(2))
    End Sub


    Private Function Nuevo_Array() As UShort()
        Dim valores(2) As UShort
        valores(0) = 5
        valores(1) = 15
        valores(2) = 25
        Return valores
    End Function
End Module
