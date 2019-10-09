Module Module1

    Sub Main()
        Dim Str1, Str2, Char1, Char2, nextChar As String
        Dim counter As Integer

        Str1 = ""
        Str2 = ""
        Char1 = ""
        Char2 = ""
        nextChar = ""
        counter = 0

        Console.Write("Enter String:")
        Str1 = Console.ReadLine

        Console.Write("Enter character to remove:")
        Char1 = Console.ReadLine

        Console.Write("Enter character to replace:")
        Char2 = Console.ReadLine

        For counter = 1 To Len(Str1)
            nextChar = Mid(Str1, counter, 1)
            If nextChar = Char1 Then
                nextChar = Char2
            End If
            Str2 = Str2 & nextChar

        Next

        Console.WriteLine("Final String:" & Str2)
        Console.ReadKey()

    End Sub

End Module
