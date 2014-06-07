using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that extracts and prints all URLs from given text.
class ExtractURLsFromText
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        List<int> urls = new List<int>();
        foreach(var tralqlq in input)
        {
            if((tralqlq.Contains("www")))
            {
                if(tralqlq.Last()=='.')
                {
                    char[] chars = tralqlq.ToCharArray();
                    for (int i = 0; i < chars.Length - 1;i++ )
                    {
                        Console.Write(chars[i]);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(tralqlq);
                }
            }
            else if(tralqlq.Contains("http://"))
            {
                if (tralqlq.Last() == '.')
                {
                    char[] chars = tralqlq.ToCharArray();
                    for (int i = 0; i < chars.Length - 1; i++)
                    {
                        Console.Write(chars[i]);
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(tralqlq);
                }
            }
        }
    }
}
