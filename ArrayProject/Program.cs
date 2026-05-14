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