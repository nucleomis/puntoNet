Imports System

Module Program
    Sub Main(args As String())

        For x = 0 To 3 Step 1
            Console.WriteLine("x : {0}", x)
        Next
        For x = 0 To 10 Step 1
            Console.WriteLine("x = " & x)
        Next

        For x = 10 To 0 Step -3
            Console.WriteLine("x= {0}", x)
        Next



    End Sub
End Module
