using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). 
class PrintDeckOf52
{
    static void Main()
    {
        string card = "2";
        for (int i = 2; i <= 14; i++)
        {
            if (i <= 10)
            {
                Console.Write(i);
                card = Convert.ToString(i);
            }
            else if (i==11)
            {
                card = "J";
                Console.Write(card);
            }
            else if (i==12)
            {
                card = "D";
                Console.Write(card);
            }
            else if (i==13)
            {
                card = "K";
                Console.Write(card);
            }
            else if (i==14)
            {
                card = "A";
                Console.Write(card);
            }
            for (int face = 1; face <= 4; face++)
            {
                switch (face)
                {
                    case 1:
                        Console.Write("♣ ");
                        Console.Write(card);
                        break;
                    case 2:
                        Console.Write("♦ ");
                        Console.Write(card);
                        break;
                    case 3:
                        Console.Write("♥ ");
                        Console.Write(card);
                        break;
                    case 4:
                        Console.WriteLine("♠");
                        break;
                }
            }
        }
    }
}