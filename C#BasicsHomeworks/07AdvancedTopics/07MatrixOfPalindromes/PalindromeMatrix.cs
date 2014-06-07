using System;
//Write a program to generate the following matrix of palindromes of 3 letters with r rows and c columns
class PalindromeMatrix
{
    static void Main()
    {
        //int r = int.Parse(Console.ReadLine());
        //int c = int.Parse(Console.ReadLine());
        string input = Console.ReadLine();
        string[] inputs=input.Split(' ');
        int r = Convert.ToInt32(inputs[0]);
        int c = Convert.ToInt32(inputs[1]);
        char[] letters = new char[26];
        for (int i = 0; i < 26; i++)
        {
            letters[i]=(Convert.ToChar(i + 97));
        }
        for(int row = 0;row<r;row++)
        {
            for(int col = 0;col<c;col++)
            {
                Console.Write(letters[row]);
                Console.Write(letters[col+row]);
                Console.Write(letters[row]+" ");
            }
            Console.WriteLine();
        }

        
    }
}
