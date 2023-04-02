using System;

public class Program
{
    public static void Main()
    {
        Address address1 = new Address("123 Main St", "Anytown", "CA", "12345");
        Address address2 = new Address("456 Oak Ave", "Anycity", "NY", "67890");
        Address address3 = new Address("789 Elm Blvd", "Anystate", "TX", "13579");

        Lecture lecture = new Lecture("Introduction to C# Programming", "Learn the basics of C# programming language", new DateTime(2023, 4, 15, 10, 0, 0), address1, "John Doe", 50);

        Reception reception = new Reception("Networking Mixer", "Meet other professionals in your industry", new DateTime(2023, 5, 20, 18, 0, 0), address2, "rsvp@example.com");

        OutdoorGathering outdoorGathering = new OutdoorGathering("Summer Picnic", "Enjoy a fun day outdoors with friends and family", new DateTime(2023, 7, 4, 12, 0, 0), address3, "Sunny");
        
            // Call methods for each event
        Console.WriteLine("Standard Details for Lecture:");
        Console.WriteLine(lecture.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details for Lecture:");
        Console.WriteLine(lecture.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description for Lecture:");
        Console.WriteLine(lecture.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Standard Details for Reception:");
        Console.WriteLine(reception.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details for Reception:");
        Console.WriteLine(reception.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description for Reception:");
        Console.WriteLine(reception.GetShortDescription());
        Console.WriteLine();

        Console.WriteLine("Standard Details for Outdoor Gathering:");
        Console.WriteLine(outdoorGathering.GetStandardDetails());
        Console.WriteLine();

        Console.WriteLine("Full Details for Outdoor Gathering:");
        Console.WriteLine(outdoorGathering.GetFullDetails());
        Console.WriteLine();

        Console.WriteLine("Short Description for Outdoor Gathering:");
        Console.WriteLine(outdoorGathering.GetShortDescription());
        Console.WriteLine();
    }

    }