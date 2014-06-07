using System;
/*Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
•	Calculates the sum of the digits 
•	Prints on the console the number in reversed order: dcba 
•	Puts the last digit in the first position: dabc
•	Exchanges the second and the third digits: acbd
*/
class FourDigitNumber
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());
        int d = number % 10;
        int c = (number / 10) % 10;
        int b = (number / 100) % 10;
        int a = (number / 1000) % 10;
        Console.WriteLine("Sum of the digits is: " +(a+b+c+d));
        Console.WriteLine("In reverse order: {0}{1}{2}{3}", d, c, b, a);
        Console.WriteLine("Last digit in first position: {0}{1}{2}{3}",d,a,b,c);
        Console.WriteLine("Second and third digit exchange: {0}{1}{2}{3}",a,c,b,d);
    }
}