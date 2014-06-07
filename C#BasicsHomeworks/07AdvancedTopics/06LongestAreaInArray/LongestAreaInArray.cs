using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program to find the longest area of equal elements in array of strings. You first should read an integer n and n strings 
//(each at a separate line), then find and print the longest sequence of equal elements (first its length, then its elements).
//If multiple sequences have the same maximal length, print the leftmost of them. 

class LongestAreaInArray
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        string[] st = new string[n];
        int count = 0;
        string word = "";
        for (int i = 0; i < n; i++)
        {
            st[i] = Console.ReadLine();
        }
        Console.WriteLine("Output:");
        for(int i = 0;i<st.Length;i++)
        {
            int tempcount = 0;
            for(int p = 0;p<st.Length;p++)
            {
                if(st[i]==st[p])
                {
                    tempcount++;
                }
            }
            if(tempcount>count)
            {
                word = st[i];
                count = tempcount;
            }
        }
        Console.WriteLine(count);
        for(int i = 0;i<count;i++)
        {
            Console.WriteLine(word);
        }
    }
}
