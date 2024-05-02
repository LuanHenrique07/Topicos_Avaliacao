Prompt ->
como fazer que so aceite um formato de texto exemplo = "12345-7"?

using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        string input = "12345-7";
        string pattern = @"^\d{5}-\d$";

        if (Regex.IsMatch(input, pattern))
        {
            Console.WriteLine("Formato válido.");
        }
        else
        {
            Console.WriteLine("Formato inválido.");
        }
    }
}