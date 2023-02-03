using System;
using System.Collections.Generic;

namespace Scripture_Challenge
{
    class Verse
    {
        private string reference;
        private string text;

        public Verse(string reference, string text)
        {
            this.reference = reference;
            this.text = text;
        }

        public string Reference
        {
            get { return reference; }
        }

        public string Text
        {
            get { return text; }
        }
    }

    class Scripture
    {
        private List<Verse> verses;

        public Scripture(List<Verse> verses)
        {
            this.verses = verses;
        }

        public List<Verse> Verses
        {
            get { return verses; }
        }
    }

    class Game
    {
        private Scripture scripture;
        private List<string> hiddenWords;

        public Game(Scripture scripture)
        {
            this.scripture = scripture;
            hiddenWords = new List<string>();
        }

        public void Play()
        {
            while (hiddenWords.Count < GetTotalWords())
            {
                Console.Clear();
                DisplayScripture();
                Console.WriteLine();
                Console.WriteLine("Press enter to hide a word or type 'quit' to end the game.");
                string userInput = Console.ReadLine();
                if (userInput.ToLower() == "quit")
                {
                    break;
                }
                HideWord();
            }
        }

        private void DisplayScripture()
        {
            foreach (Verse verse in scripture.Verses)
            {
                Console.WriteLine(verse.Reference);
                string[] words = verse.Text.Split(' ');
                foreach (string word in words)
                {
                    if (hiddenWords.Contains(word))
                    {
                        Console.Write("[...] ");
                    }
                    else
                    {
                        Console.Write(word + " ");
                    }
                }
                Console.WriteLine();
            }
        }

        private int GetTotalWords()
        {
            int totalWords = 0;
            foreach (Verse verse in scripture.Verses)
            {
                totalWords += verse.Text.Split(' ').Length;
            }
            return totalWords;
        }

        private void HideWord()
        {
            int wordIndex = new Random().Next(0, GetTotalWords());
            int currentIndex = 0;
            foreach (Verse verse in scripture.Verses)
            {
                string[] words = verse.Text.Split(' ');
                if (currentIndex + words.Length > wordIndex)
                {
                    hiddenWords.Add(words[wordIndex - currentIndex]);
                    break;
                }
                currentIndex += words.Length;
            }
        }
    }
}