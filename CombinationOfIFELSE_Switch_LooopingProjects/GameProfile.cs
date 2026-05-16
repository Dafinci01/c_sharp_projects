using System;

namespace GameApp
{
    public class GameProfile
    {
        public static void ShowScore()
        {
            int score = 150;
            string playerName = "David";
            bool isGameOver = false;


            Console.WriteLine($"Player: {playerName}");
            Console.WriteLine($"Gamescore: {score}");


            score += 50;
            if (score >= 200)
            {
                isGameOver= true;
                Console.WriteLine("Game over, you reached 200  points");

            }
            Console.WriteLine($"New Score: {score}");
            Console.WriteLine($"Gmae Over? {isGameOver}");
        }
    }
}