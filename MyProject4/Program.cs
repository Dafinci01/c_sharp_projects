using System;
/*
A trial can only move forward through phases, never skip. You write logic that enforces that. 
This teaches you how enums control state traansitions — a very real software pattern.
*/
namespace clinicalTrialApp
{
    enum TrialPhase{Preclinical, PhaseI, PhaseII, PhaseIII, PhaseIV , Terminated }
    class Program
    {
        static void Main(string[] args)
        {
            //show all phases 
            Console.WriteLine("Available phases: ");
            foreach (TrialPhase phase in Enum.GetValues(typeof(TrialPhase)))
                Console.WriteLine(phase);

            //step2; get current phase from user
            Console.Write("\nEnter current phase: ");
            string CurrentInput = Console.ReadLine();

            //step3: get the next step 
            Console.Write("\nEnter the next phase: ");
            string nextInput = Console.ReadLine();

            if (Enum.TryParse(CurrentInput, out TrialPhase current) && Enum.TryParse(nextInput , out TrialPhase next))
                           {
                //enforce one step forward only 
                if((int)next - (int)current == 1)
                    Console.Writeline($"Transition from {current} to {next} allowwed");
                else if ((int)next <= (int) current)
                    Console.WriteLine($"cannot go backward or stay at {current}");
                else
                    Console.WriteLine($"cannot skip phases - must go one step at a time ");
                    
            }
            else
            {
                Console.WriteLine("Invalid phase entered -check spelling");
            }
        }

    }    
}