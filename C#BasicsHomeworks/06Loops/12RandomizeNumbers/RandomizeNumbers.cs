using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
//Write a program that enters in integer n and prints the numbers 1, 2, …, n in random order.
class RandomizeNumbers
{
    static void Main()
    {
        //Shte komentiram vsqka stupka, zashtoto reshenieto za men, kato nachinaesht beshe trudno a saotvetno i cheteneto ot takuv :)
        Random r = new Random();
        Console.Write("Enter n: ");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];//Suzdava masiv s n na broi int
        int random = 1;
        int counter = 1;
        //Zadava stoinost na element ot masiva 0-->1 1-->2 2-->3 i taka natatuk do n-1-->n
        for (int i = 1; i <= n; i++)
        {
            numbers[i-1] = i;
        }
        //Vurti cikula dokato ne se izprintqt vsichki elementi.
        while(counter<=n)
        {
            random = r.Next(0, n);//Syzdava random chislo v range 0-n
            if(numbers[random]!=0)//Ako random izbranoto chislo ne e zanuleno
            {
            Console.Write("{0} ", numbers[random]);//izprintva izbranoto chislo
            numbers[random] = 0;//zanulqva veche izprintiranoto chislo
            counter++;//Ochevidno e.
            Thread.Sleep(5);//Zabavqneto e nujno, za pravilnata rabota na random generatora.Izpolzva za seed sistemnoto vreme i zatova prekaleno
                //burzoto mu izvikvane dava sushtoto chislo
            }
        }
        Console.WriteLine();
    }
}