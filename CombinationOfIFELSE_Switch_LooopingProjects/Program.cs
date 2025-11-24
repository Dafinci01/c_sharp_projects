using System;

namespace GameApp
{
    class Program 
    {
        static void Main()
        {
            Console.WriteLine("===game stats === ");
            GameProfile.ShowScore();


            Console.WriteLine("\n === playerProfile");
            ProfileCard.ShowProfile();

            Console.WriteLine("\npress ny key to exist");
            Console.ReadKey();

        }
    }
}
