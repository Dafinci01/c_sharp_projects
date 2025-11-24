using System;

class Program
{
    static void Main()
    {
        //using do while tasks Write a program that repeatedly asks 
        //for a positive number until the user enters a valid one.
        int number;
        do
        {
            Console.Write("Enter a positie Number: ");
            !int TryParse(ConsoleReadLine() out, number) || number <= 0;

        } while (number <= 10);
        Console.WriteLine($"You entered {number}");
    }

    static void Main(string[] args)
    {
        double balance, interestRate , targetBalance;
        Console.WriteLine("what is your current balance? ");
        bool isValidbalance = double.TryParse(ConsoleReadLine() out, balance );

        Console.Writeleine("What is your current intrest rate (in %)");
        bool isValidinterestRate = 1 + double.TryParse(ConsoleReadLine() / 100.0 out, interestRate );
    }
}