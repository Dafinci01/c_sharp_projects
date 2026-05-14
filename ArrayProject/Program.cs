// local quiz app project
/*
A local quiz app startup needs a score tracking system. 
The app runs a 5-question quiz, 
collects the player's name and each answer's score 
(entered by the player), then shows their total score,
 average, highest score, lowest score, and whether they
  passed (pass mark is 50% of total possible).

Requirements — must use:

string[] for questions (hardcode 5 questions)
int[] for scores collected via Console.ReadLine() and int.Parse()
for loop to collect input
foreach loop to display results
if/else for pass/fail
Math for total, average, highest, lowest

*/
int [] scores =  new int [5];
strings[] questions = {

}
//the for loop fil the score shelf 
for(int i = 0; i < scores.Length; i++)
{
    Console.WriteLine(qusetions[i]);
    Console.WriteLine("Input number 0-10: ");
    scores[i] = int.Parse(Console.ReadLine());

}
//calculate stats 
int sum = 0;
int highest = scores[0];
int lowest =  scores [0];
foreach (int sore in scores)
{

    sum += score ;
    if (score > highest) highest = score;
    if (score < highest ) lowest = score ;


}

//code for  calculating the average \

double average = (double)sum / score.Length;
int totalPossible = 50;
bool passed = average >= 5.0;

//display results 
Console.WriteLine("\n === Results ===");
Console.WriteLine($"Total Score: {sum}/{totalPossible}");
Console.WriteLine($" Average: {average:F1/10}");
Console.WriteLine($"highest: {highest}");
Console.WriteLine($"lowest: {lowest}");

if(passed)
{
    Console.WriteLine("Passed");
}
else 
{
    Console.WriteLine("Failed")
}