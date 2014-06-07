using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * You are given n integers (given in a single line, separated by a space). Write a program that checks whether the product of the odd elements 
 * is equal to the product of the even elements. Elements are counted from 1 to n, so the first element is odd, the second is even, etc. 
 */
class OddAndEvenProduct
{
    static void Main()
    {
        Console.Write("Enter numbers separated by spaces: ");
        string x = Console.ReadLine();
        int[] y = x.Split(' ').Select(n => Convert.ToInt32(n)).ToArray();
        //
        int oddProduct = 1;
        int evenProduct = 1;
        int couter = 0;
        foreach(int number in y)
        {
            couter++;
            if(couter%2!=0)
            {
                oddProduct *= number;
            }
            else
            {
                evenProduct *= number;
            }
        }
        if (oddProduct==evenProduct)
        {
            Console.WriteLine("yes");
            Console.WriteLine("product = "+oddProduct);
        }
        else
        {
            Console.WriteLine("no");
            Console.WriteLine("odd_product = " + oddProduct);
            Console.WriteLine("even_product = " + evenProduct);
        }
    }
}