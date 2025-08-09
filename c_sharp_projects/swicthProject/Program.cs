using System;
class Program
{
    static void Main()
    {
        /*LINK - Simple Calculator
            Ask the user for two numbers.
            Ask for an operation (+, -, *, /).
            Use switch to perform the correct calculation and show the result.

        */
        {
            Console.Write("input number A: ");
            bool isNumberAValid = int.TryParse(Console.ReadLine(), out int numberA);

            Console.Write("input number B: ");
            bool isNumberBValid = int.Tryparse(Console.ReadLine(), out int numberB);

            Console.WriteLine("input the operation wanted to perfom: ");
            string operation = Console.ReadLine();

            if (operation != "+" && operation != "-" && operation != "*" && operation != "/")
            {
                Console.WriteLine("Invalid operation, input valid operation");
            }
            if (!isNumberAValid || !isNumberBValid)
            {
                Console.WriteLine("Enter the right number, Inavlid number");
            }

            switch (operation)
            {
                case "+":
                    Console.WriteLine($"Result: {numberA + numberB}");
                    break;

                case "-":
                    Console.WriteLine($"Result: {numberA - numberB}");
                    break;

                case "*":
                    Console.WriteLine($"Result: {numberA * numberB}");
                    break;

                case "/":
                    Console.WriteLine($"Result: {numberA / numberB}");
                    break;


            }



        }

        /*
            2. Fruit Price Checker
            User enters a fruit name.
            switch matches it and displays the price.
            Add a default case for unknown fruits.

        */
        Console.WriteLine("Enter fruit name: ");
        string FruitName = Console.ReadLine().Lower();

        var FruitPrices = new Dictionary<string, double>
        {
            {"Apple",  1.4 },
            {"Banana", 0.8},
            {"Mango", 2.0 },
            {"Orange", 1.2}
        };
        switch (FruitName)
        {
            case "Apple":
                Console.WriteLine($"Apple price: ${FruitPrices["Apple"]}");
            case "Banana":
                Console.WriteLine($"Banana price: ${FruitPrices["Banana"]}");
            case "Mango":
                Console.WriteLine($"Mango price: ${FruitPrices["Mango"]}");
            case "Orange":
                Console.WriteLine($"Orange price: ${FruitPrices["Orange"]}");
            case "Default":
                return Console.WriteLine($"unknow fruit");
        }



        /*      
            . Month Name to Days Converter
            User enters a month number (1–12).
            switch returns the number of days in that month.
            Bonus: Handle leap year for February with an extra input.

        */
        Console.WriteLine("enter month Number: ");
        bool isMonthNumberValid = int.TryParse(Console.ReadLine(), out int Monthnumber);
        
        
    }
}