using System;
//Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
class BitsExchange
{
    static void Main()
    {
        Console.Write("Please eneter a number: ");
        long number = uint.Parse(Console.ReadLine());
        Console.WriteLine("You entered the number {0} in binary: {1}", number, Convert.ToString(number, 2).PadLeft(32, '0'));
        long mask = 7;
        long firstBits = ((mask << 3) & number)>>3;//Get bits 3,4,5
        long secondBits = ((mask << 24) & number)>>24;//Get bits 24,25,26
        number = number & ~(mask << 3);//Convert bits 3,4,5 to 0;
        number = number & ~(mask << 24);//Convert bits 24,25,26 to 0;
        number = number | (secondBits << 3);//Replaces bits 3,4,5 with saved bits 24,25,26
        number = number | (firstBits << 24);//Replaces bits 24,25,26 with saved bits 3,4,5
        Console.WriteLine("Result is: {0}",number);
        Console.WriteLine("In binary: {0}",Convert.ToString(number, 2).PadLeft(32, '0'));
    }
}
