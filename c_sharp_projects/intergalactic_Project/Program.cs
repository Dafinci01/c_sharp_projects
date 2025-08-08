using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace IntergalacticTravelAgency
{
    class Program
    {
        class Planet
        {
            public string Name { get; set; }
            public double DistanceLightYears { get; set; }
            public double BaseCost { get; set; }
            public int MinAge { get; set; }
            public bool RequiresMedicalCheck { get; set; }
        }

        class Booking
        {
            public string TravelerName { get; set; }
            public string PlanetName { get; set; }
            public string TravelClass { get; set; }
            public double TotalCost { get; set; }
            public DateTime BookingDate { get; set; }
        }

        static List<Booking> bookings = new List<Booking>();
        static List<Planet> planets = new List<Planet>
        {
            new Planet { Name = "Mars", DistanceLightYears = 0.00024, BaseCost = 1000, MinAge = 18, RequiresMedicalCheck = false },
            new Planet { Name = "Europa", DistanceLightYears = 0.00064, BaseCost = 2500, MinAge = 25, RequiresMedicalCheck = true },
            new Planet { Name = "Titan", DistanceLightYears = 0.00013, BaseCost = 5000, MinAge = 30, RequiresMedicalCheck = true }
        };

        static void Main(string[] args)
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                DisplayMenu();
                string choice = Console.ReadLine();

                switch (choice.ToLower())
                {
                    case "1":
                        BookTrip();
                        break;
                    case "2":
                        ViewBookings();
                        break;
                    case "3":
                        running = false;
                        SaveBookings();
                        Console.WriteLine("Thank you....");
                        break;
                }
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }

        static void DisplayMenu()
        {
            Console.WriteLine("=== Intergalactic Travel Agency ===");
            Console.WriteLine("1. Book a Trip");
            Console.WriteLine("2. View Bookings");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice (1-3): ");
        }

        static void BookTrip()
        {
            Console.WriteLine("\n==== Book a Trip ====");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(name))
            {
                Console.WriteLine("Name cannot be empty");
                return;
            }

            Console.Write("Enter your age: ");
            if (!int.TryParse(Console.ReadLine(), out int age) || age < 0)
            {
                Console.WriteLine("Invalid age");
                return;
            }

            Console.Write("Enter your budget ($): ");
            if (!double.TryParse(Console.ReadLine(), out double budget) || budget < 0)
            {
                Console.WriteLine("Invalid budget");
                return;
            }

            Console.WriteLine("\nAvailable Planets:");
            for (int i = 0; i < planets.Count; i++)
            {
                var p = planets[i];
                Console.WriteLine($"{i + 1}. {p.Name} (Cost: ${p.BaseCost:F2}, {p.DistanceLightYears:F6} light-years)");
            }

            Console.Write("Choose a planet (1-3): ");
            string planetChoice = Console.ReadLine();
            Planet selectedPlanet = null;
            switch (planetChoice)
            {
                case "1":
                    selectedPlanet = planets[0];
                    break;
                case "2":
                    selectedPlanet = planets[1];
                    break;
                case "3":
                    selectedPlanet = planets[2];
                    break;
                default:
                    Console.WriteLine("Invalid planet choice");
                    return;
            }

            if (age < selectedPlanet.MinAge)
            {
                Console.WriteLine($"Sorry, you must be at least {selectedPlanet.MinAge} to travel to {selectedPlanet.Name}.");
                return;
            }

            if (selectedPlanet.RequiresMedicalCheck)
            {
                Console.Write("Have you passed a medical check? (yes/no): ");
                if (Console.ReadLine().ToLower() != "yes")
                {
                    Console.WriteLine($"A medical check is required for {selectedPlanet.Name}.");
                    return;
                }
            }

            if (budget < selectedPlanet.BaseCost)
            {
                Console.WriteLine($"Insufficient budget. {selectedPlanet.Name} costs ${selectedPlanet.BaseCost:F2}.");
                return;
            }

            Console.WriteLine("\nTravel Classes:");
            Console.WriteLine("1. Economy");
            Console.WriteLine("2. Luxury");
            Console.Write("Choose travel class (1-2): ");
            string classChoice = Console.ReadLine();
            string travelClass = (classChoice == "1") ? "Economy" : (classChoice == "2") ? "Luxury" : null;

            if (travelClass == null)
            {
                Console.WriteLine("Invalid travel class");
                return;
            }

            double classMultiplier = (travelClass == "Luxury") ? 1.5 : 1.0;
            double distanceFactor = selectedPlanet.DistanceLightYears * 10000;
            double totalCost = selectedPlanet.BaseCost * classMultiplier + distanceFactor;

            double finalCost = totalCost;
            if (budget > totalCost * 1.5)
            {
                finalCost *= 0.9;
                Console.WriteLine("You qualify for a 10% discount");
            }

            string recommendation = travelClass == "Luxury"
                ? "Enjoy our premium cryo-sleep chambers!"
                : "Economy class offers great value for interstellar travel";
            Console.WriteLine(recommendation);

            Console.WriteLine($"\nTrip to {selectedPlanet.Name} ({travelClass})");
            Console.WriteLine($"Total Cost: ${finalCost:F2}");
            Console.Write("Confirm booking (yes/no): ");

            if (Console.ReadLine().ToLower() == "yes")
            {
                bookings.Add(new Booking
                {
                    TravelerName = name,
                    PlanetName = selectedPlanet.Name,
                    TravelClass = travelClass,
                    TotalCost = finalCost,
                    BookingDate = DateTime.Now
                });
            }
            else
            {
                Console.WriteLine("Booking Cancelled");
            }
        }

        static void ViewBookings()
        {
            Console.WriteLine("\n=== Your Bookings ===");
            if (bookings.Count > 0)
            {
                foreach (var booking in bookings)
                {
                    string dateDisplay = booking.BookingDate.Date == DateTime.Today
                        ? "Today"
                        : booking.BookingDate.ToString("MM/dd/yy");
                    Console.WriteLine($"Traveler: {booking.TravelerName}, Planet: {booking.PlanetName}, Class: {booking.TravelClass}, Cost: ${booking.TotalCost:F2}, Booked: {dateDisplay}");
                }
            }
            else
            {
                Console.WriteLine("No bookings found.");
            }
        }

        static void SaveBookings()
        {
            try
            {
                if (bookings.Count == 0)
                    return;

                string json = JsonSerializer.Serialize(bookings, new JsonSerializerOptions { WriteIndented = true });
                string path = Path.Combine(AppContext.BaseDirectory, "bookings.json");
                File.WriteAllText(path, json);
                Console.WriteLine($"Bookings saved to {path}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving bookings: {ex.Message}");
            }
        }
    }
}
