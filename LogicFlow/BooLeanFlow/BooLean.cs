

namespace LogicFlow.BooLeanFlow
{
    public class BooLean
    {
        public void Run()
        {
        Console.WriteLine("Enter an Integer: ");
        int myInt = Convert.ToInt32(Console.ReadLine());


        bool isLessThan10 = myInt < 10;
        bool isBetween0And5 = (0 <= myInt) && (myInt <= 5);

        Console.WriteLine($"Integer is Less than 10 {isLessThan10}");
        Console.WriteLine($"Integer is between 0 and 5 {isBetween0And5}");


        Console.WriteLine($"Exactly one is true? {isLessThan10 ^ isBetween0And5}");


        Console.ReadKey();
        }

        private void BooleanPractice()
        {
            //program to check if  a number is even
            Console.Clear();
            Console.WriteLine("Enter number: ");
            int myInt = Convert.ToInt32(Console.ReadLine());
            bool isNumberEven = myInt % 2 == 0;
            Console.WriteLine($"isBoolean {isNumberEven}");


        }

    }
  
}
