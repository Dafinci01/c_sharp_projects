using System;
namespace  Projects 
{
 // patient record system
 enum BloodGroup {APositive, ANegative, BPositive, BNegative, OPositive, ONegative, ABPositive, ABNegative}
 struct Patient { 
        //fields, constructor , methods
        //step1. patirnts with field
        public string Name;
        public int Age;
        public  BloodGroup bloodgroup;
        public double Weight;
        public bool IsAdmitted;
        //constructor to set all five fields 
        public Patient (string name, int age, BloodGroup bg ,double weight  )
        {
            Name = name;
            Age = age;
            BloodGroup = bloodgroup;
            Weight = weight;
            IsAdmitted = false;

        }
        //methods: that print all fields correctly  
        public void PrintRecord()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Age: {Age}");
            Console.WriteLine($"BloodGroup: {bloodGroup}");
            Console.WriteLine($"Weight: {Weight}");
        }
        //method to check if paient is underweight 
        public bool isUnderweight()
        {
            return weight < 50;
        }
    }    

// DRUG INVENTORY SYSTEM 
 enum DrugCategory{Antibiotic, Antihypertensive, Antidiabetic, Analgesic, Respiratory}
 struct Drug{
    //fields , constructor, methods
    public string Name;
    public DrugCategory Category;
    public double PricePerUnit;
    public int QuantityInStock;
    public bool RequiresPrescription;


    //constructor 
    public Drug (string name, DrugCategory cat, double priceperunit, int quantityinstock,    )
    {
        Name = name;
        Category = cat;
        PricePerUnit = priceperunit;
        QuantityInStock = quantityinstock;
        RequiresPrescription = true;
        
    }
    public void PrintDrugInfo()
    {
        Console.WriteLine($"Drug Name: {Name}");
        Console.WriteLine($"Drug Category: {Category}");
        Console.WriteLine($"Drug pricce per unit: {PricePerUnit}");
        Console.WriteLine($"Drug Quantity: {QuantityInStock}");
        Console.WriteLine($"Drug Name: {RequiresPrescription}");
    }
    public void IsLowStock()
    {
        return quantityinstock < 20;
    }
    public void GetTotalValue()
    {
        return PricePerUnit * QuantityInStock;
    }

 }
 //SALES VISIT TRACKER PROJECT
 enum VisitOutcome { Detailed, SamplesGiven, Deferred, NotAvailable, FollowUpRequired}
 struct DoctorVisit{ 
    public string DoctorName;
    public string Hospital;
    public string ProductDiscussed;
    public VisitOutcome Outcome;
    public bool WillPrescribe;

    //add Constructor 
    public VisitedDoctor("string doctorname , string hospital, string productdiscussed , ")
    {
        DoctorName = doctorname;
        Hospital = hospital;
        ProductDiscussed = productdiscussed;
        Outcome = visitedoutcome;
        WillPrescribe = true;
    }
    public void PrintVisitSummary()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("");
    }
    public bool IsPositiveOutcome()
    {
        return Outcome == VisitOutcome.Detailed || SamplesGiven;
    }
 }

 //Bank ACCT Tracker Project
 
 class Program 
 {
    static void Main(string[] args)
    {
        // call eah project 
        RunPatientRecord();
        RunDrugInventory();
        RunSalesVisitTracker();
        RunBankAccountSystem();
    }
    static void RunPatientRecord()
    {
        Console.WriteLine("===Patient record system === ");
        Patient patient1 =  new Patient(....);

        //calling
        patient1.PrintRecord();
        Console.WriteLine($"is underweight: {patient.isUnderweight()}");
        //value type copying crating another 
        NewPatient patient5 = patient1;
        patient5.Name = "adeleke"

        Console.WriteLine($"Patient 1 name: {patient1.Name}");

    }
    static void RunDrugInventory()
    {
        Console.WriteLine("====Drug Inventory System====");
        Drug newDrug1 = new Drug (......);
        Drug newDrug2 = new Drug (......);
        Drug newDrug3 = new Drug (......);
        Drug newDrug4 = new Drug (......);
        Drug newDrug5 = new Drug (......);

        //print drugInformatiiom
        newDrug1.PrintDrugInfo();
        newDrug2.PrintDrugInfo();
        newDrug3.PrintDrugInfo();
        newDrug4.PrintDrugInfo();
        newDrug5.PrintDrugInfo();

        //print total stock
        foreach (Drug drug in inventory)
        {
            double value = drug.PricePerUnit * QuantityInStock;
            if (drug.QuantityInStock < 20 || drug.QuantityInStock == 0);
            
            {
                Console.WriteLine("Sold Out!");
            }
            else if (value > 500)
            {
                Console.WriteLine("high value!")
            }
            else
            {
                Console.WriteLine("Normal Stock Level")
            }


        }
        if (drug.IsLowStock())
        {
            Console.WriteLine($"kindly reordr {drug.Name}")

        }


    }
 }



}