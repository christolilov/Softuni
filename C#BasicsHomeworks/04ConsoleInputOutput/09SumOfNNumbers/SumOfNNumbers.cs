using System;
//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. 
//Note that you may need to use a for-loop. 
    class SumOfNNumbers
    {
        static void Main()
        {
            Console.WriteLine("This program will sum some numbers for you!");
            Console.Write("How many numbers would you like to sum: ");
            double sum = 0;
            int numberOfInputs = int.Parse(Console.ReadLine());
            for(int currentInput = 1;currentInput<=numberOfInputs;currentInput++)
            {
                Console.Write("Please enter number " +currentInput+": ");
                double currentSum = double.Parse(Console.ReadLine());
                sum+=currentSum;
            }
            Console.WriteLine("The sum of the numbers is: "+sum);
        }
    }

