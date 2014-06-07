using System;
/*Write a program that, depending on the user’s choice, inputs an int, double or string variable. 
 * If the variable is int or double, the program increases it by one. If the variable is a string, the program appends "*" at the end. 
 * Print the result at the console. Use switch statement. */
class PlayWithIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:");
        Console.WriteLine("1 ---> int");
        Console.WriteLine("2 ---> double");
        Console.WriteLine("3 ---> string");
        int varType = int.Parse(Console.ReadLine());
        switch(varType)
        {
            case 1:
                Console.Write("Please enter a integer number: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine((a+1));
                break;

            case 2:
                Console.Write("Please enter double: ");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine((b + 1));
                break;

            case 3:
                Console.Write("Please enter string: ");
                string c = Console.ReadLine();
                Console.WriteLine(c+"*");
                break;

            default:
                Console.WriteLine("Invalid selection!");
                break;
        }
    }
}