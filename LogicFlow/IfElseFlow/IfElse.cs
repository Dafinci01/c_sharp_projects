using System;
using System.Linq;




//if-else
namespace LogicFlow.IfElse
{
    public class IfElse
    {
        string comparison;

        public void Run()
        {
            Console.WriteLine("enter a number ");
            double var1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter  the second number");
            double var2 = Convert.ToDouble(Console.ReadLine());

            if (var1 > var2)
                comparison = "less than";
            else if (var1 == var2)
                comparison = "equal to";
            else
                comparison = "greater than";
            Console.WriteLine($"The first number is {comparison} the second numeber ");
            Console.ReadKey();

        }
        private void GradeChecker()

        {
            //program to check score 
            Console.WriteLine("Enter your score: ");

            int GradeScore = Convert.ToInt32(Console.ReadLine());

            string grade;
            if (GradeScore >= 70)
            {
                grade = "A";
            }
            else if (GradeScore >= 60 && GradeScore <= 69)
            {
                grade = "B";

            }
            else if (GradeScore >= 50 && GradeScore <= 59)
            {
                grade = "C";
            }
            else
            {
                grade = "Fail";
            }
            Console.WriteLine("Your grade is {grade}");
        }

        private void LoginSimulation()
        {
            //login simulator 
            Console.Clear();
            Console.WriteLine("Enter Username : ");

            string Username = Console.ReadLine();

            Console.WriteLine("Enter Password: ");
            string mypassword = Console.ReadLine();
            

           
            if (Username == "registered_username" && mypassword == "saved_password" )
            {
                Console.WriteLine("Login Successful");
            }
            else 
            {
                Console.WriteLine("Invalid credentials");
            }
        }
        //Boolean + if Else Combo 

        private void BooleanIfelse()
        {       
            
            Console.WriteLine("Enter your age: ");
            int Age = Convert.ToInt32(Console.ReadLine());
            


            Console.WriteLine("Enter your Country: ");
            string Country = Console.ReadLine();


            if(Age >= 18 && Country == "Nigeria")
            {
                Console.WriteLine("welcome!");
            }
            else
            {
                Console.WriteLine("Invalid Credentials try again");
            }

        }
        private void PasswordStrenght()
        {
            Console.WriteLine("Enter Password: ");
            string password = Console.ReadLine();

            //Boolean checks 
            bool longEnough = password.Length >= 8;
            bool hasDigit = password.Any(char.IsDigit);
            bool hasUpper = password.Any(char.IsUpper);


            //count how many conditions are meet 
            int score = 0;
            if (longEnough) score++;
            if(hasDigit) score++;
            if (hasUpper) score++;

            //use the score to display output of [passwod strenfght]
            if (score == 1)
            {
                Console.WriteLine(" password not long enough");

            }
            if(score == 2)
            {
                Console.WriteLine("pssworrd strenght: medium");
            }
            if (score ==3)
            {
                Console.WriteLine("password strenght: strong");
            }
        }

    }
}

