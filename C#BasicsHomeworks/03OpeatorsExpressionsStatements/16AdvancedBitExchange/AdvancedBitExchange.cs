using System;
//Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer. 
//The first and the second sequence of bits may not overlap.
class AdvancedBitExchange
{
    static void Main()
    {
        Console.Write("Enter number: ");
        long number = uint.Parse(Console.ReadLine());
        Console.Write("Enter p: ");
        int p = int.Parse(Console.ReadLine());
        Console.Write("Enter q: ");
        int q = int.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        int k = int.Parse(Console.ReadLine());
        if (Math.Max(p, q) + k > 32)
        {
            Console.WriteLine("Out of range");
        }
        else if (Math.Min(p, q) + k > Math.Max(p, q))
        {
            Console.WriteLine("Overlapping");
        }
        else
        {
            int counter = q;
            for (int i = p;i<=p+k-1;i++)
            {
                //Prosto kodut ot predishnata zadacha, vkaran v for cikul i s druga maska.
                long mask = 1;
                long firstBits = ((mask << i) & number) >> i;//Get bit p
                long secondBits = ((mask << counter) & number) >> counter;//Get bit q
                number = number & ~(mask << i);//Convert bit p to 0
                number = number & ~(mask << counter);//Convert bit q to 0
                number = number | (secondBits << i);//Replace bit p with q
                number = number | (firstBits << counter);//Replace bit q with p
                counter++;
            }
            Console.WriteLine(number);
            Console.WriteLine(Convert.ToString(number, 2).PadLeft(32,'0'));
        }
    }
}