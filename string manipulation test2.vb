﻿Module Module1

    Sub Main()
        Dim instring As String
        Dim char1, char2 As String
        Dim highest As Integer = 0
        Dim countchar As Integer = 0
        Dim mostchar As String = ""

        Console.WriteLine("Enter A string :")
        instring = Console.ReadLine
        highest = 1

        If len(instring) <> 0 Then

            For count As Integer = 1 To Len(instring)
                countchar = 0
                char1 = Mid(instring, count, 1)

                For count2 As Integer = 1 To Len(instring)

                    char2 = Mid(instring, count2, 1)

                    If char1 = char2 Then
                        countchar = countchar + 1
                    End If
                Next

                If highest < countchar Then
                    highest = countchar
                    mostchar = char1
                End If

            Next

            If highest > 1 Then

                Console.WriteLine("Most repeated character is " & mostchar & ", and it is repeated " & highest & " times.")
                Console.ReadKey()

            Else : Console.WriteLine("Your string has no repeating characters.")
                Console.ReadKey()
                Console.WriteLine(" bye >:(")
                Console.ReadKey()

            End If

        Else : Console.WriteLine("You entered nothing. >:( ")
            Console.ReadKey()
            Console.WriteLine("bye.")
            Console.ReadKey()
        End If

    End Sub


End Module