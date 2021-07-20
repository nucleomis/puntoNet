Imports System

Module Program
    Sub Main(args As String())
        FechaActual()
        Console.WriteLine(HoraActual())
    End Sub

    Sub FechaActual()
        Console.WriteLine("fecha actual: " + DateTime.Now)
    End Sub

    Function HoraActual()
        Dim fecha = DateTime.Now
        Return fecha.ToString("hh:mm tt")
    End Function
End Module
