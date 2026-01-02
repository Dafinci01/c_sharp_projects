// See https://aka.ms/new-console-template for more information
private void ConversionChecker()
{
    int number = 24;
    double ageNumber = number;


    Console.Write("Enter Something: ");
    string input  = Console.ReadLine();

    //Tryparse  = explicit 
    bool success = int.TryParse(input, out int number);
    if(success)
    {
        Console.WriteLine("Valid Number. Conversion successful");
        Console.WriteLine("The number is: {number}");

            
    }
    else 

    {
        Console.WriteLine("Invalid input. Could not convert to a number ");
    }
}