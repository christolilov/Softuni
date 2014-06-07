using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
//Write a program that enters 3 integers n, min and max (min ≤ max) and prints n random numbers in the range [min...max].
class RandomNumbersInRange
{
    static void Main()
    {
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        Console.Write("Enter the start of the range: ");
        int min = int.Parse(Console.ReadLine());
        Console.Write("Enter the end of the range: ");
        int max = int.Parse(Console.ReadLine());
        Random r = new Random();
        int x = 0;
        if(min<=max)
        {
            for (int i = 1; i <= n;i++)
            {
//Napulno celenasocheno zabavqne na programata.Randomgenerator-a razchita na seed ot sistemniqt chasovnik, za tova pri prekaleno burzoto
//mu povtorno izvikvane, vrushta sushtoto chislo.Tova dalech ne e nai-optimiziraniqt nachin i ne trqbva da bude izpolzvan izvun tozi primer!
//-----------------------------------------------------------------------------------------------------------------------------------------------
                for (int f = 1; f < 5;f++)
                { 
                    x = r.Next(min, max);
                    Thread.Sleep(10);
                }
//-----------------------------------------------------------------------------------------------------------------------------------------------
                Console.Write(x);
                if (i < n)
                {
                    Console.Write(" ");
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
        else
        {
            Console.WriteLine("Invalid input");
        }
    }
}