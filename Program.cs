using System;

namespace HW_5._2
{
    internal class Program
    {
        static string SplitWord(string text)
        {
            string[] wordsSplit = text.Split(' ',',','.','!','?');
            string newText = ReverseWord(wordsSplit);
            return newText;
        }
        static string ReverseWord(string[] text) 
        {
            Array.Reverse(text);
            string str = string.Join(" ", text);
            return str;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите предложение: ");

            string newString = Console.ReadLine();

            newString = SplitWord(newString);


            Console.WriteLine(newString);
            Console.ReadLine();
        }
    }
}
