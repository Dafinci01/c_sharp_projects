using System;

class AddingVariables
{
    public static void ShowAddition()
    {
        // Task1 make number become 57 
        int number = 20; // the original number is 20
        number += 40; // add 40 to number to make it 60
        number -= 3;// minus 3  from  number make it 57 
        Console.WriteLine("Task 1 result: " + number);

        //task 2 follow operations in order
        int coins = 100;// start a 100
        coins += 20;   //add 20 
        coins -= 5; // subtract 5 from 
        coins *= 10; //multiply 10 
        coins /= 5;  //divide by 5
        coins %= 7; //remainder when / 7
        Console.WriteLine("Task 2 result: " + coins);

    }
}