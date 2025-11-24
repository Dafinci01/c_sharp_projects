using System;


namespace GameApp
{
    public class ProfileCard
    {
        public static void ShowProfile()
        {
            string fullName = "David Odelana";
            int age = 16;
            double heightInMeters = 1.75;
            string favoriteColor = "Blue";
            bool likesProgramming = false;

            Console.WriteLine("==================");
            Console.WriteLine("PERSONAL PROFILECARD");
            Console.WriteLine("====================");
            Console.WriteLine($"Name: {fullName}");
            Console.WriteLine($"Age: i'm {age} years");
            Console.WriteLine($"Height: {heightInMeters}");
            Console.WriteLine("---====================");


            Console.WriteLine("you juxt had a birthday");
            age++;
            Console.WriteLine($"New Age: {age} Years");          
        }

        
    }
}
