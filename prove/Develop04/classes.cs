using System;
using System.Collections.Generic;

namespace MindfulnessApp
{
    
    // Parent class for all mindfulness activities
    class MindfulnessActivity
    {
        protected int duration;
        protected string description;

        // Common starting message for all activities
        public void StartActivity()
        {
            Console.WriteLine("Starting " + description);
            Console.WriteLine("Duration: " + duration + " seconds");
            Console.WriteLine("Get ready to begin in 3 seconds...");
            System.Threading.Thread.Sleep(3000);
        }

        // Common ending message for all activities
        public void EndActivity()
        {
            Console.WriteLine("Good job! You have completed " + description);
            Console.WriteLine("Duration: " + duration + " seconds");
            Console.WriteLine("Returning to main menu in 3 seconds...");
            System.Threading.Thread.Sleep(3000);
        }

        // Common function to show spinner animation
        protected void ShowSpinner(int seconds)
        {
            for (int i = 0; i < seconds; i++)
            {
                Console.Write("/");
                System.Threading.Thread.Sleep(1000);
                Console.Write("\b-");
                System.Threading.Thread.Sleep(1000);
                Console.Write("\b\\");
                System.Threading.Thread.Sleep(1000);
                Console.Write("\b|");
                System.Threading.Thread.Sleep(1000);
            }
            Console.Write("\b");
        }
    }

    // Breathing Activity class
    class BreathingActivity : MindfulnessActivity
    {
        // Constructor to set duration and description
        public BreathingActivity(int duration)
        {
            this.duration = duration;
            this.description = "Breathing Activity";
        }

        // Function to run the activity
        public void RunActivity()
        {
            StartActivity();

            Console.WriteLine("This activity will help you relax by walking you through breathing in and out slowly. Clear your mind and focus on your breathing.");

            int count = duration / 4; // Display "Breathe in..." and "Breathe out..." each for 4 seconds
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine("Breathe in...");
                ShowSpinner(4);
                Console.WriteLine("Breathe out...");
                ShowSpinner(4);
            }

            EndActivity();
        }
    }

    // Reflection Activity class
    class ReflectionActivity : MindfulnessActivity
    {
        private List<string> prompts;
        private List<string> questions;

        // Constructor to set duration, description, prompts and questions
        public ReflectionActivity(int duration)
        {
            this.duration = duration;
            this.description = "Reflection Activity";
            this.prompts = new List<string> { "Think of a time when you stood up for someone else.", "Think of a time when you did something really difficult.", "Think of a time when you helped someone in need.", "Think of a time when you did something truly selfless." };
            this.questions = new List<string> { "Why was this experience meaningful to you?", "Have you ever done anything like this before?", "How did you get started?", "How did you feel when it was complete?", "What made this time different than other times when you were not as successful?", "What is your favorite thing about this experience?", "What could you learn from this experience that applies to other situations?", "What did you learn about yourself through this experience?", "How can you keep this experience in mind in the future?" };
        }

        // Function to run the activity
        public void RunActivity()
        {
            StartActivity();

            Console.WriteLine("This activity will help you reflect on times in your life when you have been brave, kind, or selfless. Take a moment to think about each prompt and answer the corresponding question.");
                    foreach (string prompt in prompts) 
        {
            Console.WriteLine(prompt);
            System.Threading.Thread.Sleep(5000); // Give user 5 seconds to think about prompt

            foreach (string question in questions) 
            {
                Console.WriteLine(question);
                System.Threading.Thread.Sleep(3000); // Give user 3 seconds to answer question
            }
        }

        

    EndActivity();
   

}

// Listing Activity class
class ListingActivity : MindfulnessActivity
{
private List<string> prompts;

 // Constructor to set duration, description, and prompts
    public ListingActivity(int duration)
    {
        this.duration = duration;
        this.description = "Listing Activity";
        this.prompts = new List<string> { "Who are people that you appreciate?", "What are personal strengths of yours?", "Who are people that you have helped this week?", "When have you felt the Holy Ghost this month?", "Who are some of your personal heroes?" };
    }

    // Function to run the activity
    public void RunActivity()
    {
        StartActivity();

        Console.WriteLine("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");

        // Select a random prompt
        Random rand = new Random();
        string prompt = prompts[rand.Next(prompts.Count)];
        Console.WriteLine(prompt);

        int count = duration / 5; // Display prompt for 5 seconds, then give user 5 seconds to list items
        for (int i = 0; i < count; i++)
        {
            System.Threading.Thread.Sleep(5000); // Give user 5 seconds to think about prompt
            Console.WriteLine("Go!");
            int itemcount = 0;
            DateTime start = DateTime.Now;
            while ((DateTime.Now - start).TotalSeconds < 5) // Give user 5 seconds to list items
            {
                string item = Console.ReadLine();
                if (item == "")
                    break;
                itemcount++;
            }
            Console.WriteLine("You listed {0} items.", itemcount);
        }

        EndActivity();
    }
}

}

}