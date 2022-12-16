// See https://aka.ms/new-console-template for more information

using System;
using System.Diagnostics.Tracing;

Console.WriteLine("escribe una palabra");
string word = Console.ReadLine();
bool isPalindrome = true;
 for (int i = 0; i < word.Length && isPalindrome; i++)
{
    if (word[i] != word[word.Length -i -1])
    {
        isPalindrome = false;
    }
}
if (isPalindrome)
    Console.WriteLine($"{word } Es Palindromo");
else
    Console.WriteLine($"{word } No es palindromo");