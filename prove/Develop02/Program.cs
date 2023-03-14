using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");
    }
}

/*
Solution Idea

What if the Journal app gave people a simple prompt to respond to every day? It could also record the response somewhere for them and even add elements like the data automatically.

These features could help address some of the challenges that keep people from journaling, and could be included in a mobile app or on a web page. The actual interface is not that critical, but the ability for a program to help solve a real problem is important to recognize.

Program Specification

For this assignment you will write a program to help people record the events of their day by supplying prompts and then saving their responses along with the question and the date to a file.
Functional Requirements

This program must contain the following features:

    Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
    Display the journal - Iterate through all entries in the journal and display them to the screen.
    Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
    Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored the journal.
    Provide a menu that allows the user choose these options
    Your list of prompts must contain at least five different prompts. Make sure to add your own prompts to the list, but the following are examples to help get you started:
        Who was the most interesting person I interacted with today?
        What was the best part of my day?
        How did I see the hand of the Lord in my life today?
        What was the strongest emotion I felt today?
        If I had one thing I could do over today, what would it be?
    Your interface should generally follow the pattern shown in the video demo below.

Design Requirements

In addition, your program must:

    Contain classes for the major components in the program.
    Contain at least two classes in addition to the Program class.
    Demonstrate the principle of abstraction by using member variables and methods appropriately.

    */
