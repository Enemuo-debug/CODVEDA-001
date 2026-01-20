// C# DataTypes and Variables...
// What are variables? Variables are containers used to hold data in a program
// While Data Types define the kind of data in a variable
using BankAppIllustration;
using AnimalKingdom;

string Name = "Chimzuruoke Enemuo";
int Age = 19;
bool isMale = true;
float CGPA = 5.0f;
double accountBalance = Math.Pow(2, 50);
char favoriteLetter = 'A';



Console.WriteLine(@$"My name is {Name}, I am a {Age} year old {(isMale ? "boy" : "girl")}.
My CGPA is {CGPA} and my account balance is ${accountBalance} (IJN).
My favorite letter is {favoriteLetter}.
");

// Create Banks and Customers
Bank firstBank = new Bank("First Bank");
Bank secondBank = new Bank("GTBank");

Customer firstCustomer = new Customer("Chimzuruoke Enemuo", firstBank, "1234");
Customer secondCustomer = new Customer("Zurus06", secondBank, "5678");

// Perform some operations
// Deposit Money and Show Customer Info
firstCustomer.DepositMoney(5000);
secondCustomer.DepositMoney(10000);
firstCustomer.AboutCustomer();
secondCustomer.AboutCustomer("5678");
firstCustomer.AboutCustomer("0000");

// List all Banks in the System
Console.WriteLine("List of Banks in the System:");
var banks = Bank.GetAllBanks();
if (banks != null)
{
    foreach (var bank in banks)
    {
        Console.WriteLine(bank);
    }
}

// To Implement Polymorphism and Inheritance, I'd use this animal kingdom structure
Non_Vertebrate snake = new Snake();
snake.DisplayInfo();
snake.Sound();

Vertebrate dog = new Dog();
dog.DisplayInfo();
dog.Sound();