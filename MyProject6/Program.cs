using System;

enum Day
{
    Monday, 
    Tuesday,
    Wednesday,
    Thursday,
    Friday,
    Saturday,
    Sunday
                                                                                                                                                                                                                                                   
}
class Program
{
    static void Main()
    {
        Day today = Day.Thursday;

        Console.WriteLine(today);
        Console.WriteLine((int)today);
        if (today == Day.Friday)
        {
            Console.WriteLine("Weekend Soon!");

        }
        else 
        {
            Console.WriteLine("Still working...");
        }
    }
}

///ATM menu