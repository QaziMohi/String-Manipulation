Module Module1

    Sub Main()

        Dim strpan, str1 As String
        Dim count As Integer
        Dim ispangram As Boolean

        strpan = "abcdefghijklmnopqrstuvwxyz"
        str1 = ""
        count = 0
        ispangram = False

        Console.WriteLine("                                          Pangram Checker")






        Console.Write("Enter a sentence to check if it is a pangram: ")

        str1 = Console.ReadLine
        str1 = LCase(str1)
        If Len(str1) >= 26 Then
            ispangram = True
            For count = 1 To 26
                If InStr(str1, Mid(strpan, count, 1)) = 0 Then
                    ispangram = False
                End If
            Next
        End If
        If ispangram = True Then
            Console.Write("the sentence is a pangram")
        Else
            Console.Write("the sentence is not a pangram")
        End If
        Console.ReadKey()
    End Sub

End Module
