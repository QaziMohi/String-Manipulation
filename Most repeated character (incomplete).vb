Module Module1

    Sub Main()

        Dim character, nextchar, currentchar As Char
        Dim count, a, i, high As Integer
        Dim Str1 As String

        count = 0
        a = 0
        i = 0
        Str1 = ""
        character = ""
        nextchar = ""
        high = 0


        Console.WriteLine("Most repetitive letter checker")

        Str1 = Console.Read

        For count = 1 To Len(Str1)
            nextchar = Mid(Str1, count, 1)
            a = 0
            For i = 1 To Len(Str1)
                currentchar = Mid(Str1, i, 1)
                a = a + 1
                End
            Next i

            If a > high Then
                high = a
                character = nextchar

            End If
        Next count


        Console.Write("Most repeated letter")

        Console.WriteLine(high)

        Console.ReadKey()

    End Sub

End Module
