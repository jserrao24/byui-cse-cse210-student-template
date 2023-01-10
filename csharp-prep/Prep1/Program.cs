using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade? ");
        string  userInput= Console.ReadLine();
        int grade = int.Parse(userInput);
        Console.Write(grade);

        if (grade >= 90 )
{
        Console.WriteLine("\nA");
}
        else if (grade < 80)
{
        Console.Write("\nB");
}


    }
}