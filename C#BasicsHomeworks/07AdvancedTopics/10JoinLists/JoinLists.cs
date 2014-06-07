using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that takes as input two lists of integers and joins them. The result should hold all numbers from the first list, and all numbers from the 
//second list, without repeating numbers, and arranged in increasing order. The input and output lists are given as integers, separated 
//by a space, each list at a separate line. 
class JoinLists
{
    static void Main()
    {
        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();
        List<string> firstList = firstInput.Split(' ').ToList();
        List<string> secondList = secondInput.Split(' ').ToList();
        foreach(var number in secondList)
        {
            if(!firstList.Contains(number))
            {
                firstList.Add(number);
            }
        }
        firstList = firstList.Distinct().ToList();
        firstList.Sort();
        foreach (var number in firstList)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
