using System;
/*Patient comes in, you assess them, assign priority, route to ward.
 Switch statements decide what happens next.
*/
namespace HospitalTriage
{
    enum TriagePriority { Immediate, Urgent, Delayed , Minimal , Deceased }
    enum WardType {Emergency, ICU, General, Pediatric, Psychiatric  }

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("enter name of patient: ");
            string PatientName = Console.ReadLine();


            Console.WriteLine("get priorities");
            foreach (TriagePriority  p in Enum.GetValues (typeof(TriagePriority)))
               Console.WriteLine(p);

            //get priority input 
            Console.Write("\n Enter patiennt priotiy ");
            string PriorityInput = Console.ReadLine();
            if(Enum.TryParse(PriorityInput, out TriagePriority selectedPriority))
            {
                //switch  patient to correct priotiy 
                switch (selectedPriority)
                {
                    case TriagePriority.Immediate:
                        Console.WriteLine($"{patientName} -> Emergency Ward: Trauma team on standby ");
                        break;
                    case TriagePriority.Urgent:
                        Console.WriteLine($"{patientName} -> Icu:  ");
                        break;
                     case TriagePriority.Immediate:
                        Console.WriteLine($"{patientName} -> Emergency Ward: Trauma team on standby ");
                        break;
                    case TriagePriority.Urgent:
                        Console.WriteLine($"{patientName} -> ");
                        break;
                }
                else
                {

                }
            }

            Console.WriteLine("get ward types");
            foreach(WordType w in Enum.GetValues(typesof(WardTypes)))
                Console.WriteLine(w);
            
            Console.Write("emter   ward typr: ")
            string wardInput = Console.ReadLine();

            if(Enum.TryParse(wardInput, out WardType selectedWard))
            {
                switch (selectedWard)
                {
                    case WardType.Emergency:
                        Console.WriteLine("{}");
                        break
                    case WardType.Emergency:
                        Console.WriteLine("{}");
                        break
                    case WardType.Emergency:
                        Console.WriteLine("{}");
                        break
                    case WardType.Emergency:
                        Console.WriteLine("{}");
                        break
                }
            }
            else
            {
                Console.WriteLine("Invalid ward entered");
            }
        }
    }
}