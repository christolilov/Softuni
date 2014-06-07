using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
//Write a program that calculates with how many zeroes the factorial of a given number n has at its end. 
//Your program should work well for very big numbers, e.g. n=100000.
class TrailingZeroes
{
    static void Main()
    {
        //Second, cleaner solution.
        BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger result = 1;
        BigInteger counter = 0;
        for (int i = 1; i <= n; i++)
        {
            result *= i;
        }
        while(result%10==0)
        {
            result /= 10;
            counter++;
        }
        Console.WriteLine(counter);

        //My first solution, using strings.
       /* BigInteger n = BigInteger.Parse(Console.ReadLine());
        BigInteger result = 1;
        BigInteger counter = 0;
        for(int i = 1;i<=n;i++)
        {
            result *= i;
        }
        string resultAsString = Convert.ToString(result);
        List<char> numbers = new List<char>();
        foreach(char ch in resultAsString)
        {
            numbers.Add(ch);
        }
        numbers.Reverse();
        for(int f = 0;f<resultAsString.Length+1;f++)
        {
            if(numbers[f]=='0')
            {
                counter++;
            }
            else if(numbers[f]!='0')
            {
                break;
            }
        }
        Console.WriteLine(counter); */
    }
}