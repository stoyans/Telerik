/*Write a program that creates an array containing all letters from the alphabet (A-Z). Read a word from the console and print the index of each of its letters in the array.*/

using System;
using System.Collections.Generic;

class IndexOfLetters
{
    static void Main()
    {
        char[] alphabet = new char[26];
        Console.Write("enter a string: ");
        string word = Console.ReadLine();

        for (int i = 0; i < alphabet.Length; i++)
        {
            alphabet[i] = (char)(i + 65); //Filling the char array with capital letters
        }
        Console.WriteLine("The indexes of the letters from the alphabet are: ");
        Console.Write("{");
        for (int i = 0; i < word.Length; i++)
        {
            for (int j = 0; j < alphabet.Length; j++)
            {
                if (alphabet[j] == word[i])
                {
                    Console.Write("{0} ",Array.IndexOf(alphabet, word[i]));
                }
            }
        }
        Console.WriteLine("}");
    }
}

