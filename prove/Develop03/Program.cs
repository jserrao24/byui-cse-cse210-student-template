using System;
using System.Collections.Generic;
using Scripture_Challenge;

namespace ScriptureHiding
{
    class Program
    {
        static void Main(string[] args)
        {
            Verse verse1 = new Verse("John 3:16", "For God so loved the world that he gave his one and only Son, that whoever believes in him shall not perish but have eternal life.");
            Verse verse2 = new Verse("Proverbs 3:5-6", "Trust in the Lord with all your heartand lean not on your own understanding; in all your ways submit to him, and he will make your paths straight.");
            List<Verse> verses = new List<Verse> { verse1, verse2 };
            Scripture scripture = new Scripture(verses);
            Game game = new Game(scripture);
            game.Play();
        }
    }
}