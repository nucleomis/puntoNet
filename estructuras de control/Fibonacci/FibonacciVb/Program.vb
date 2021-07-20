Imports System

Module Program
    Sub Main(args As String())
        Fibonacci()
    End Sub

    Sub Fibonacci()
        Dim a = 0
        Dim b = 1
        For i = 1 To 4
            Console.WriteLine(a)
            Console.WriteLine(b)
            a += b
            b += a
        Next
    End Sub
End Module
