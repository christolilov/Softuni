using System;
/*We are given an integer number n, a bit value v (v=0 or 1) and a position p. Write a sequence of operators (a few lines of C# code) 
 *that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.*/
class ModifyAGivenBit
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter a bit value(1 or 0): ");
        int v = int.Parse(Console.ReadLine());;
        Console.WriteLine("Enter a position to be changed: ");
        int p = int.Parse(Console.ReadLine());
        Console.WriteLine("You want to change the bit of the number {2} at position {0} with {1} !",p,v,Convert.ToString(n,2).PadLeft(16, '0'));
        if(v==1)
        {
            int mask = 1 << p;
            int changed = n | mask;
            Console.WriteLine(changed);
            Console.WriteLine(Convert.ToString(changed, 2).PadLeft(16,'0'));
        }
        else if(v==0)
        {
            int mask = ~(1 << p);
            int changed = (n & mask);
            Console.WriteLine(changed);
            Console.WriteLine(Convert.ToString(changed, 2).PadLeft(16, '0'));
        }
        else
        {
            Console.WriteLine("Your input is wrong!");
        }
    }
}