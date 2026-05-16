using System;

namespace DrugPrescriptionTracker
{
    enum DrugSchedule {I, II, III , IV , V}
    enum PrescriptionStatus {Pending , Approved, Dispensed , Rejected , Expired}
    enum RouteOfAdministration {Oral , IntraVenous, IM , Sublingual, Topical }
    
    class Program
    {
        static void Main(string[] args)
        {
            //Get input from user 
            Console.Write("Enter patient name: ");
            string patientName = Console,ReadLine();


            Console.Write("Enter patient age: ");
            string patientAge = Console.ReadLine();


            Console.Write("Enter Drug Schedule(I, II, III, IV, V)");
            string scheduleInput = Console.ReadLine();

            Console.Write("Enter Route of administration");
            string RouteOfAdministration = Console.ReadLine();


            if(Enum.TryParse(scheduleInput, out DrugSchedule schedule))
            {
                //now the enum logic kikcs in 
                /* Build a console app — doctor inputs a drug name and patient age group,
                 app checks schedule,
                 decides if prescription needs extra authorization. Real logic, real rules.
                */
                PrescriptionStatus status;
                switch (schedule)
                {
                    case DrugSchedule.I:
                        status   = PrescriptionStatus.Rejected;
                        break;
                    case  DrugSchedule.II:
                        status = PrescriptionStatus.Pending;
                        break;
                    default:
                        status = PrescriptionStatus.Approved;
                        break;

                }
                Console.Writeline($"\nPatient: {patientName}, Age: {patientAge}");
                Console.WriteLine($"Drug: {drugName}, Schedule: {schedule}");
                Console.WriteLine($"Prescription Status: {status}");
            }
            else
            {
                Console.WriteLine("Invalid schedule Entered ");
            }

        }
    }
}