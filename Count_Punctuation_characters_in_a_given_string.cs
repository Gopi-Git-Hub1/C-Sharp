using System;

namespace Count_Punctuation_characters_in_a_given_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '!' || input[i] == ';' || input[i] == ',' ||
                    input[i] == ':' || input[i] == '?' || input[i] == '.')
                {
                    count++;
                }
            }
            Console.WriteLine($"No of punctuations are: {count}");
        }
    }
}

