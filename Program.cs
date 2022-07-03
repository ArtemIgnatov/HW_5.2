using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

            string newText = Console.ReadLine();

            newText = SplitWord(newText);


            Console.WriteLine(newText);
            Console.ReadLine();
        }
    }
}
