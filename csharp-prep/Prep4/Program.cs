using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numberList = new List<int>();

        int number = 2;
        while (number != 0)
        {
            Console.WriteLine("Enter a number:");

            string userInput = Console.ReadLine();
            number = int.Parse(userInput);

            if (number != 0)
            {
                numberList.Add(number);
            }
        }

        Console.WriteLine("Numbers in the list:");
        foreach (int num in numberList)
        {
            Console.WriteLine(num);
        }
    }
}