using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that reads a list of names and prints for each name how many times it appears in the list. 
//The names should be listed in alphabetical order. 
class CountOfNames
{
    static void Main()
    {
        string firstInput = Console.ReadLine();
        List<string> firstList = firstInput.Split(' ').ToList();
        var secondList = firstList.Distinct().ToList();
        secondList.Sort();
        foreach(var name in secondList)
        {
            int count = 0;
            for(int i = 0;i<firstList.Count;i++)
            {
                if (name == firstList[i])
                {
                    count++;
                }
            }
            Console.WriteLine("{0} -> {1}",name,count);
        }
    }
}