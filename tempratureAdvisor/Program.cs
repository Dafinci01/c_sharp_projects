using System;
class Program
{
    static void Main()
    {
        // practiding if/else using Temprature Advisor 
        Console.WriteLine("Enter the temprature: ");
        bool isValid = double.TryParse(Console.ReadLine(), out double temprature);
        if (!isValid)
        {
            Console.WriteLine("Invalid temprature input");
            return; //stop futher procesing 
        }
        if (temprature < 10)
        {
            Console.WriteLine("its cold, wear a jacket");
        }
        else if (temprature >= 10 && temprature <= 25)
        {
            Console.WriteLine("Its plesant , enjoy thr day ");
        }
        else
        {
            Console.WriteLine("It's hot stay hydrated");
        }
        //practicing switch statement day of the week translator
               
    }
}