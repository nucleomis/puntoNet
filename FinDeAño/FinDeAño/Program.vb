Imports System

Module Program
    Sub Main(args As String())

        Dim fecha_actual = DateTime.Now
        Dim fin_de_a�o = New DateTime(fecha_actual.Year, 12, 31)
        Dim diferencia As TimeSpan
        diferencia = fin_de_a�o - fecha_actual

        Dim dias = diferencia.Days

        Console.WriteLine(dias)
    End Sub
End Module
