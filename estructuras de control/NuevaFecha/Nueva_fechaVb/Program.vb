Imports System

Module Program
    Sub Main(args As String())
        Dim mas_dias, dia, mes, año As Integer

        Console.Write("ingrese el dia: ")
        dia = Console.ReadLine()

        Console.Write("ingrese el mes: ")
        mes = Console.ReadLine()

        Console.Write("ingrese el año: ")
        año = Console.ReadLine()

        Dim fecha = New DateTime(año, mes, dia)

        Console.WriteLine("la fecha queda de la siguiente manera: " & fecha.ToString("dd/MM/yyyy"))

        Console.Write("ingrese la cantidad de dias que quiere sumar: ")

        mas_dias = Console.ReadLine()

        Console.WriteLine("la fecha con los la cantidad de dias sumados da como resultado: ")
        Console.WriteLine(NuevaFecha(fecha, mas_dias))
    End Sub

    Public Function NuevaFecha(f As Date, dias As Integer)
        Dim fecha = f.AddDays(dias)
        Return fecha.ToString("dd/MM/yyyy")
    End Function
End Module
