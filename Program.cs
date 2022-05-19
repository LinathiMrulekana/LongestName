using System;

namespace Assignment_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text;
            string[] stringlist;
            int ni = 0 ,len, max = 0;

            Console.Write("Enter a sentence: ");
            text = Console.ReadLine();
            stringlist = text.Split(' ');
            len = stringlist.Length;

            for (int i = 0; i < len; i++)
            {
                if(stringlist[i].Length > max)
                {
                    max = stringlist[i].Length;
                    ni = i;
                }
            }
            Console.WriteLine("Longest string: {0}",stringlist[ni]);
            Console.ReadLine();
            }
    }
}
