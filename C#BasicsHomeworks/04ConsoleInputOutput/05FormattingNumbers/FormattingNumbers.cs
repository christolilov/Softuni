using System;
//........1 hour later
class FormattingNumbers
{
    static void Main()
    {
        Console.Write("Please enter the first number: ");
        int a = int.Parse(Console.ReadLine());
        string aBinary = Convert.ToString(a, 2).PadLeft(10, '0');
        Console.Write("Please enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Please enter the third number: ");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("|{0,-10:X}|{1}|{2,10:0.00}|{3,-10:0.000}|",a,aBinary,b,c);
    }
}