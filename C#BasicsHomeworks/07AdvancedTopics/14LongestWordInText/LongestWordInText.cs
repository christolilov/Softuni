using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to find the longest word in a text. 
class LongestWordInText
{
    static void Main()
    {
        string[] input = Console.ReadLine().Split(' ');
        int count = 0;
        string longest = "";
        for(int i = 0;i<input.Length;i++)
        {
            char[] temp = input[i].ToCharArray();
            int length = temp.Length;
            if(temp[temp.Length-1]=='.')
            {
                length--;
            }
            if(length>count)
            {
                count = length;
                longest = input[i];
            }
        }
        foreach(char ch in longest)
        {
            if(ch!='.')
            {
                Console.Write(ch);
            }
        }
        Console.WriteLine();
    }
}
