' This line declares a module named Module1
Module Module1

    ' This line defines the Main subroutine, which is the entry point of the program
    Sub Main()

        ' Set the foreground color of the console output to Cyan
        System.Console.ForegroundColor = ConsoleColor.Cyan

        ' Prompt the user to enter a number using a colored message
        System.Console.Write("Pls Enter Number: ")

        ' Set the foreground color of the user input prompt to Yellow
        System.Console.ForegroundColor = ConsoleColor.Yellow

        ' Read the user's input, convert it to an integer, and store it in the variable 'Number'
        Dim Number As Integer = Convert.ToInt32(Console.ReadLine())

        ' Use a Select Case statement to check the value of the 'Number' variable
        Select Case Number
            ' Case 0 to 9: These cases handle numbers from 0 to 9 and print the corresponding word
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
                ' Case Else: This case handles any number outside the range of 0 to 9
            Case Else
                Console.WriteLine("Please enter a number from 0 to 9.")
        End Select

        ' Display a separator line with Magenta foreground color
        System.Console.ForegroundColor = ConsoleColor.Magenta
        System.Console.WriteLine("-----------------------")

        ' Display programmer information with Red foreground color
        System.Console.ForegroundColor = ConsoleColor.Red
        System.Console.WriteLine("Programmer : Amin Mirzaei - Github(UserName) : AminMirzaeiOne")

        ' Pause the console window until the user presses any key
        System.Console.ReadKey()

    End Sub

End Module
