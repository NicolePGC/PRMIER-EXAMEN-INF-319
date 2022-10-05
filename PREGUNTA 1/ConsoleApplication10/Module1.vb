Module Module1

    Sub Main()
        Console.WriteLine("INTRODUCIR 3 NUMEROS:")
        Dim a As Integer
        a = Console.ReadLine()
        Dim b As Integer
        b = Console.ReadLine()
        Dim c As Integer
        c = Console.ReadLine()
        GoTo ORDENAR

ORDENAR:
        If a > b Then
            If b > c Then
                Console.WriteLine("orden: " + c.ToString() + " " + b.ToString() + " " + a.ToString())
            Else
                If a > c Then
                    Console.WriteLine("orden: " + b.ToString() + " " + c.ToString() + " " + a.ToString())
                Else
                    Console.WriteLine("orden: " + b.ToString() + " " + a.ToString() + " " + c.ToString())
                End If
            End If
        Else
            If a > c Then
                Console.WriteLine("orden: " + c.ToString() + " " + a.ToString() + " " + b.ToString())
            Else
                If b > c Then
                    Console.WriteLine("orden: " + a.ToString() + " " + c.ToString() + " " + b.ToString())
                Else
                    Console.WriteLine("orden: " + a.ToString() + " " + b.ToString() + " " + c.ToString())
                End If
            End If

        End If



        Console.ReadKey()


    End Sub

End Module
