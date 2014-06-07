using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a list of letters and prints for each letter how many times it appears in the list. 
//The letters should be listed in alphabetical order.
class CountOfLetters
{
    static void Main()
    {
        string firstInput = Console.ReadLine();
        List<string> firstList = firstInput.Split(' ').ToList();
        List<char> newList = firstInput.Distinct().ToList();
        newList.Sort();
        foreach(var ch in newList)
        {   
            int count = 0;
            for(int i = 0;i<firstList.Count;i++)
            {
                if(firstList[i]==Convert.ToString(ch))
                {
                    count++;
                }
            }
            Console.WriteLine("{0} -> {1}",ch,count);
        }
    }
}