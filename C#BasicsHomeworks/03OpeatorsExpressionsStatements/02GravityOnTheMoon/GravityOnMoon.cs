using System;
//The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates the weight of a man on the moon 
//by a given weight on the Earth.
class GravityOnMoon
{
    static void Main()
    {
        Console.WriteLine("This program will calculate your weight on the moon!");
        Console.Write("Please enter your weight on Earth: ");
        double weight = double.Parse(Console.ReadLine());
        double weightOnMoon = 0.17 * weight;
        Console.WriteLine("Your weight on the moon is " +weightOnMoon+ "!");
    }
}