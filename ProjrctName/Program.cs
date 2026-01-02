using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //password strenght checker 
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine()!;


            //checkpoint to handle paswword strenght , contains digit, uppercase or letter
            bool longEnough = password.Length >= 8;
            bool hasDigit = password.Any(char.IsDigit);
            bool hasUpper = password.Any(char.IsUpper);


            int score = 0;
            if (longEnough) score++;
            if (hasDigit) score++;
            if (hasUpper) score++;


            if (score == 1)
            {
                Console.WriteLine("password weak");
            }
            else if(score == 2)
            {
                Console.WriteLine("password medium");

            }
            else if( score == 3)   
            {
                Console.WriteLine("password strong!");
            }

            Console.ReadKey(); //keeps console open 
        }

        /**

        Concepts: if-else chains, while loop, menu systems
        What to build:
        Program starts with a pin login
        After login, show a loop-menu:
        Check Balance
        Withdraw
        Deposit
        Exit
        User keeps choosing actions until Exit.
        Why it’s great
        Every action uses conditions, calculations, and loops.

        
        **/
         public void AtmSimulation()
         {
            Console.Clear();
            Console.WriteLine("Enter your pin login: ");

            string Pin = Console.ReadLine();

            //check whether pin is the same as saved pin 
            if (pin == saved_pin)
            {
                Console.WriteLine("Welcome {user}!");
            }
            Console.WriteLine("select from menu");
           
            private void showMenuDashboard()
            {
                while (true)
                {
                    Console.Clear();
                    Console.WriteLine("1.Check Balance ");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Deposit");
                    Console.WriteLine("4.Exit");
                    Console.WriteLine("5. Choose an option 1-4");

                }
                string? choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        CheckBalance();
                        break;
                    case "2":
                        Withdraw();
                        break;
                    case "3":
                        Deposit();
                        break;
                    case "4":
                        Console.WriteLine("Thank you!");
                        return;
                    default:
                        Console.WriteLine("Invalid option!");
                        break;
                }
                Console.WriteLine("\n Press any key to continue");
                Console.ReadKey();

                

            }


            
         }

        private static void CheckBalance()
        {
            Console.WriteLine($"Your balance is: {acctbalance:C}");
         
        }
        private  static void Withdraw()
        {
            Console.WriteLine($"amount to withdraw: ");
            //parse 
            if(double.TryParse(Console.ReadLine(), out double amount) && amount <= acctbalance && amount > 0)
            {
                acctbalance -= amount;
                Console.WriteLine($"Please take your cash. New balance: {acctbalance:C}");              
            }
            else 
            {
                Console.WriteLine("Invalid or insufficient funds!");
            }
        }

        private static void Deposit()
        {
            Console.WriteLine("Enter the amount to be deposited: ");
            if(double.TryParse(Console.ReadLine(), out double amount) && amount > 0)
            {
                acctbalance += amount;
                Console.WriteLine($"Deposit Succesful. New Balance {acctbalance:C}");
            }
            else 
            {
                Console.WriteLine("Invalid amount");
            }
        }



    }
    //Project 3 Quiz app 
/**Concepts: arrays, for loops, increment score, evaluation
What to build:
A 5-question quiz:
Loop through questions
Accept user answers
Compare to correct answers
Add score
At the end: show percentage + pass/fail (boolean


**/
private static void  QuizApp()
{
    
}
  
