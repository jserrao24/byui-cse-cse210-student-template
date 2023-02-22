using System;
using System.Collections.Generic;
using MindfulnessApp;

class Program
{
    static void Main(string[] args)
    {
        // Welcome message
        Console.WriteLine("Welcome to the Mindfulness App!");

        while (true)
        {
            // Display main menu and get user input
            Console.WriteLine("\nPlease choose an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Exit");
            Console.Write("Enter your choice: ");
            string input = Console.ReadLine();

            if (input == "1")
            {
                // Run breathing activity
                BreathingActivity breathingActivity = new BreathingActivity(60);
                breathingActivity.RunActivity();
            }
            else if (input == "2")
            {
                // Run reflection activity
                ReflectionActivity reflectionActivity = new ReflectionActivity(120);
                reflectionActivity.RunActivity();
            }
            else if (input == "3")
            {
                // Exit the app
                Console.WriteLine("Thank you for using the Mindfulness App. Goodbye!");
                break;
            }
            else
            {
                // Invalid input
                Console.WriteLine("Invalid input. Please enter a valid choice.");
            }
        }
    }
}