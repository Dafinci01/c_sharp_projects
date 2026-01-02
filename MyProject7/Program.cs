using System;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("--Kitchen Renovation Budget ---");
        Console.WriteLine("_____________________________-");


        //phase 1: implicit conversion 
        //Goal: Mix an integer to get  a double total 
        double pricePerTile = 4.99; // the price (pricise double)
        int tileQuantity = 120; // the number of tiles needed 

        //implicit conversion occurs: the int is automatically promoted to a 
        //doub;e before the multiplication happens , ensuring the total is accurate

        double subtotalCost = pricePerTile * tileQuantity;

        Console.WriteLine($"1. Subtotal Tile Cost: ${subtotalCost:F2}");
        Console.WriteLine("Calculatin was done implicitly in double");

        Console.WriteLine("---------------------");


        double preciseTilesNeeded = 45.3;
        //Problem: we must find the numbre of full boxes we can afford
        // we need to force the decimal count(double) into a whole number

        //we do that by performing explicit conversion(casting); we lose the .3 tiles(the remainder)
        int fullBoxesToBuy = (int)preciseTilesNeeded;


        Console.WriteLine($"Precise Tiles needed: {preciseTilesNeeded}");
        Console.WriteLine($"Full Boxes to purchase: {fullBoxesToBuy}");
        Console.WriteLine("Explicit conversion [casting] discarded the 0.3");

        //lets calculate the real money loss for fun 
        double moneyToDonate = subtotalCost - (int)subtotalCost;
        Console.WriteLine($"Change(lost to casting): ${moneyToDonate:F2}");

        Console.WriteLine("------------------");

        //Phase 3: Convert.ToX(Handing user measurement input)
        //Goal: ask thwe user for room dimensiona 

        Console.Write("3. Enter the room lenght in meters  ");
        string lengthInput = Console.ReadLine();


        Console.Write("Enter the room width in meters ");
        string widthInput = Console.ReadLine();


        //convert.Todouble(): we must turn the string input inot usable 
        //decimal numbers 

        double roomLength = Convert.ToDouble(lengthInput);
        double roomWidth = Convert.ToDouble(widthInput);

        //calculate area using the converted double values 

        double roomArea = roomLength  * roomWidth;

        Console.WriteLine($"\n Room area Calcuated: {roomArea:F2}sq. meters.");
        Console.WriteLine("Required 'Convert.ToDouble ' to use string input in math");

        Console.WriteLine("---------------");
        Console.WriteLine("Planner Complete. press Enter to exit");

        Console.ReadLine();

    }
}