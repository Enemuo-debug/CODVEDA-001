
using BankAppIllustration;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File("log.txt", rollingInterval: RollingInterval.Day) // Mean that a log file is created to save my logs and the rolling interval is showing how often new files shd be created to further seggregate my logs
    .CreateLogger();

try
{
    // Create Banks and Customers
    Bank firstBank = new("First Bank");
    Bank secondBank = new("GTBank");

    Customer firstCustomer = new("Chimzuruoke Enemuo", firstBank, "1234");
    Customer secondCustomer = new("Zurus06", secondBank, "5678");

    // Perform some operations
    // Deposit Money and Show Customer Info
    firstCustomer.DepositMoney(5000);
    secondCustomer.DepositMoney(10000);
    firstCustomer.AboutCustomer();

    try
    {
        secondCustomer.AboutCustomer("5678");
    }
    catch (InvalidPinException ex)
    {
        Log.Error(ex, "Invalid PIN entered for {CustomerName}", secondCustomer.CustomerName);
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Finished trying to get customer details.");
    }

    try
    {
        firstCustomer.AboutCustomer("0000");
    }
    catch (InvalidPinException ex)
    {
        Log.Error(ex, "Invalid PIN entered for {CustomerName}", firstCustomer.CustomerName);
        Console.WriteLine(ex.Message);
    }
    finally
    {
        Console.WriteLine("Finished trying to get customer details.");
    }

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
}
catch (Exception ex)
{
    Log.Fatal(ex, "An unhandled exception occurred.");
}
finally
{
    Log.CloseAndFlush();
}