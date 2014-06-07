using System;
//Write a program that reads 3 integer numbers from the console and prints their sum. 
//Programata beshe napisana s pomosht ot lektor, primera e s izpolzvane na masivi.
class SumOfThreeInts
{
    static void Main()
    {
        Console.WriteLine("This program will calculate the sum of 3 numbers!");

        while (true)
        {
            try
            {        
                //Tova e realnata chast ot programata!Ostanaloto e uprajnqvane na hvashtane na greshki v inputa!
                Console.Write("Please enter the first number: ");
                double a = double.Parse(Console.ReadLine());
                Console.Write("Please enter the second number: ");
                double b = double.Parse(Console.ReadLine());
                Console.Write("Please enter the third number: ");
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine("The result is: " + (a + b + c));
                return;
            }
            catch (FormatException)
            {
                Console.WriteLine("You must enter a number!");
            }
        }
    }
}