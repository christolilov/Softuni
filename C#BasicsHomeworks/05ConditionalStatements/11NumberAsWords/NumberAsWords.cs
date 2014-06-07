using System;
//Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. 
class Program
{
    static void Main(string[] args)
    {
        int i = int.Parse(Console.ReadLine());
        string[] single = {"Zero","One","Two","Three","Four","Five","Six","Seven","Eight","Nine"};
        string[] singleLow = { "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        string[] doubles = {"Ten","Eleven","Twelve","Thirteen","Fourteen","Fiveteen","Sixteen","Seventeen","Eighteen","Nineteen"};
        string[] doublesLow = {"ten","eleven","twelve","fiveteen","fourteen","fiveteen","sixteen","seventeen","eighteen","nineteen"};
        string[] tens = { "Twenty", "Thirty", "Fourty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety" };
        string[] tensLow = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        string[] hundreds = { "One hundred", "Two hundred", "Three hundred", "Four hundred", "Five hundred", "Six hundred", "Seven hundred", "Eight hundred", "Nine hundred" };
        if(i>=0 && i<=999)
        {
            if(i<10)
            {
                Console.WriteLine(single[i]);
            }
            else if(i>=10 && i<20)
            {
                Console.WriteLine(doubles[i-10]);
            }
            else if(i>=20 && i <100)
            {
                Console.Write(tens[(i / 10)-2]);
                if (i % 10 != 0)
                {
                    Console.Write(" "+singleLow[(i % 10) - 1]);
                }
            }
            else if(i>=120 && i<1000)
            {
                Console.Write(hundreds[(i / 100)-1]);
                if(i%100!=0)
                {
                    Console.Write(" and ");
                    Console.Write(tensLow[(((i/10)%10)-2)]);
                }
                if(i%10!=0)
                {
                    Console.Write(" " + singleLow[(i % 10) - 1]);
                }
            }
            else if(i==100)
            {
                Console.WriteLine("One hundred");
            }
            else if(i>100 && i<120)
            {
                Console.Write("One hundred and ");
                if(i<110)
                {
                    Console.Write(singleLow[(i % 10)-1]);
                }
                if(i>=110)
                {
                    Console.Write(doublesLow[i % 10]);
                }
            }
        }
        Console.WriteLine();
    }
}