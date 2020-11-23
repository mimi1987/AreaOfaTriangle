Imports System

Module Program
    Sub Main(args As String())
        'Declarations
        Dim BaseLength, Height, Area As Decimal

        'Ask The User For Input
        Console.WriteLine("Base length of the triangle (cm): ")
        BaseLength = Console.ReadLine()
        Console.WriteLine("Height of the triangle (cm): ")
        Height = Console.ReadLine()

        'Calculate The Area Of The Triangle
        Area = (BaseLength * Height) / 2

        'Output The Area Of The Triangle
        Console.WriteLine("The area of the triangle is " & Area & "cm².")

        'ReadKey To Keep Console Window Open
        Console.ReadKey()
    End Sub
End Module
