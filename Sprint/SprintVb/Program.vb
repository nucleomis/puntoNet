Imports System

Module Program
    Sub Main(args As String())
        Dim año, mes, dia As Integer
        Dim cantidad_horas As Double
        Dim horas = 0

        Console.Write("ingrese el año: ")
        año = Console.ReadLine()

        Console.Write("ingrese el mes: ")
        mes = Console.ReadLine()

        Console.Write("ingrese el dia: ")
        dia = Console.ReadLine()

        Console.Write("ingrese la cantidad de horas a sumar: ")
        cantidad_horas = Console.ReadLine()

        Dim fecha = New DateTime()

        fecha = fecha.AddYears(año - 1)
        fecha = fecha.AddMonths(mes - 1)
        fecha = fecha.AddDays(dia - 1)

        Console.WriteLine(Chr(10) & "agregando las horas: " & fecha)

        fecha = fecha.AddSeconds(cantidad_horas * 3600)

        Console.WriteLine(Chr(10) & "la fecha resultante es: " + fecha)
    End Sub
End Module
