
using System;  
using System.Collections.Generic;  

public class PromptGenerator{

        public PromptGenerator();
                private List<string> prompts = new List<string>();
                {
                "Who was the most interesting person I interacted with today?",
                "What was the best part of my day?",
                 "How did I see the hand of the Lord in my life today?",
                 "What was the strongest emotion I felt today?",
                "If I had one thing I could do over today, what would it be?"
                 };              

}




/*


    public void AddPrompt(string prompt)
    {
        // Add a custom prompt to the list
        prompts.Add(prompt);
    }

    public string GetRandomPrompt()
    {
        // Generate a random prompt from the list
        Random rand = new Random();
        int index = rand.Next(prompts.Count);
        return prompts[index];
    }
}      States/variable/attributes;

        Does a PromptGenerator need to store anything?

        */