Module Module1

    Sub Main()

        Dim str1, strvowel, nextchar As String
        Dim count, n, a As Integer

        str1 = ""
        strvowel = "aeiou"
        count = 0

        Console.Write("Enter string to check how many vowels there are: ")
        str1 = Console.ReadLine

        For count = 1 To Len(str1)
            nextchar = Mid(str1, count, 1)
            n = InStr(strvowel, nextchar)
            If n > a Then
                a = a + 1
            End If
        Next

        Console.Write("Number of vowels: ")
        Console.Write(a)
        Console.ReadKey()

    End Sub

End Module
