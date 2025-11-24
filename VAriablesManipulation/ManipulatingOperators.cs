using System;

class ManipulatingOperators
{
    public static void ShowManipulation()
    {
        double  firstNumber, secondNumber;
        string userName; 
        Console.WriteLine("Enter your name");
        //username 
        userName = Console.ReadLine();
        Console.WriteLine($"Welcome{userName}!");
        Console.WriteLine("Now give me another number");
        firstNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Enter the second Number");
        secondNumber = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine($"the sum of {firstNumber}  and {secondNumber}  is {firstNumber + secondNumber} ");

        Console.WriteLine($" the result of subtracting  {firstNumber} and {secondNumber} is {firstNumber - secondNumber}");


    }
}