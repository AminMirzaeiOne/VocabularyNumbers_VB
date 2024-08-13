Module Module1

    Sub Main()
        System.Console.ForegroundColor = ConsoleColor.Cyan
        System.Console.Write("Pls Enter Number: ")
        System.Console.ForegroundColor = ConsoleColor.Yellow
        Dim Number As Integer = Convert.ToInt32(Console.ReadLine())
        Select Case Number
            Case 0
                Console.WriteLine("Zero")
            Case 1
                Console.WriteLine("One")
            Case 2
                Console.WriteLine("Two")
            Case 3
                Console.WriteLine("Three")
            Case 4
                Console.WriteLine("Four")
            Case 5
                Console.WriteLine("Five")
            Case 6
                Console.WriteLine("Six")
            Case 7
                Console.WriteLine("Seven")
            Case 8
                Console.WriteLine("Eight")
            Case 9
                Console.WriteLine("Nine")
            Case Else
                Console.WriteLine("Please enter a number from 0 to 9.")
        End Select

        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")
        System.Console.ForegroundColor = ConsoleColor.Red
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")

        System.Console.ReadKey()
    End Sub

End Module
