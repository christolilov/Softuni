using System;
//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. 
//Write a program that reads the information about a company and its manager and prints it back on the console.
class PrintCompanyInfo
{
    static void Main()
    {
        string name;
        string address;
        string phoneNumber;
        string faxNumber;
        string website;
        string managerFirst;
        string managerLast;
        int age;
        string managerPhone;

        Console.Write("Enter the company name: ");
        name = Console.ReadLine();
        Console.Write("Enter the company address: ");
        address = Console.ReadLine();
        Console.Write("Enter the company phone number: ");
        phoneNumber = Console.ReadLine();
        Console.Write("Enter the company fax number: ");
        faxNumber = Console.ReadLine();
        Console.Write("Enter the company website: ");
        website = Console.ReadLine();
        Console.Write("Enter the manager's first name: ");
        managerFirst = Console.ReadLine();
        Console.Write("Enter the manager's last name: ");
        managerLast = Console.ReadLine();
        Console.Write("Enter the manager's age: ");
        age =int.Parse(Console.ReadLine());
        Console.Write("Enter the manager's phone: ");
        managerPhone = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("Company Details:\n Name: {0} \n Address: {1} \n Phone: {2} \n Fax: {3} \n Website: {4}", name, address, phoneNumber, faxNumber, website);
        Console.WriteLine("Manager Details: \n First Name: {0} \n Last Name: {1} \n Age: {2} \n Phone: {3}",managerFirst, managerLast, age, managerPhone);
    }
}