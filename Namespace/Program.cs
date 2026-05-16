//Control flow
using System;
using RandomPractice.UI;
using RandomPractice.Characters.Enemies;


namespace RandomPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            var btn = new Button();
            var z = new Zombie();

            btn.Click();
            z.bite();
        }
        
    }

}