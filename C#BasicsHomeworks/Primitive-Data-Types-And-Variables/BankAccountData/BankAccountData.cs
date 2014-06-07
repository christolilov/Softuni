using System;
/*A bank account has a holder name (first name, middle name and last name), available amount of money (balance), 
* bank name, IBAN, 3 credit card numbers associated with the account. 
* Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.*/
class BankAccountData
{
    static void Main()
    {

        string firstName = "Nedelcho";
        string middleName = "Chikchirchkov" ;
        string lastName = "Podgumerov";
        decimal balance = 200000.56m;
        string bankName = "SoftBank";
        string iban = "BG 57 SoBa 0000 0023 12";
        long ccn1 = 9872846498459459 ;
        long ccn2 = 9872855468459459;
        long ccn3 = 9872846412359459;
        Console.WriteLine("First Name:{0}{9}Middle Name:{1}{9}Last Name:{2}{9}Balance:{3}{9}Bank Name:{4}{9}IBAN:{5}{9}Credit Card 1:{6}{9}Credit Card 2:{7}{9}Credit Card 3:{8}{9}", firstName, middleName, lastName, balance, bankName, iban, ccn1, ccn2, ccn3, Environment.NewLine);
    }
}