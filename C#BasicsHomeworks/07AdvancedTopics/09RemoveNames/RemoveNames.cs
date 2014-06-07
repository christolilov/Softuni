using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that takes as input two lists of names and removes from the first list all names given in the second list. 
//The input and output lists are given as words, separated by a space, each list at a separate line. 
class RemoveNames
{
    static void Main()
    {
        string firstInput = Console.ReadLine();
        string secondInput = Console.ReadLine();
        List<string> firstList = firstInput.Split(' ').ToList();
        List<string> secondList = secondInput.Split(' ').ToList();
        foreach(string name in secondList)
        {
            for (int i = 0; i < firstList.Count;i++ )
            {
                if(firstList[i]==name)
                {
                    firstList.RemoveAt(i);
                    i--;
                }
            }
        }
        foreach(var name in firstList)
        {
            Console.Write(name + " ");
        }
        Console.WriteLine();
    }
}