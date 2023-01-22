using System;


        public class Prompts
    {
        private static List<string> prompts = new List<string>()
        {
            "What did you learn today?",
            "What are you grateful for?",
            "What is something you accomplished today?",
            "What did you struggle with today?",
            "What are your goals for tomorrow?"
        };

        public static string GetRandomPrompt()
        {
            Random random = new Random();
            int index = random.Next(prompts.Count);
            return prompts[index];
        }
    }

