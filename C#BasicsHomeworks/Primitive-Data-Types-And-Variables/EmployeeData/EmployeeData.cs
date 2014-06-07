using System;
/*A marketing company wants to keep record of its employees. Each record would have the following characteristics:
•	First name
•	Last name
•	Age (0...100)
•	Gender (m or f)
•	Personal ID number (e.g. 8306112507)
•	Unique employee number (27560000…27569999)
Declare the variables needed to keep the information for a single employee using appropriate primitive data types. */
class EmployeeData
{
    static void Main()
    {

        string firstName = "Nedelcho";
        string lastName = "Podgumerov";
        sbyte age = 55;
        char gender = 'm';
        long personalID = 8306112507;
        uint employeeNumber = 27569999;
        Console.WriteLine("Name: " + firstName + " " + lastName);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Gender: " + gender);
        Console.WriteLine("Personal ID number: " + personalID);
        Console.WriteLine("Unique employee number: " + employeeNumber);
    }
}