namespace BankAppIllustration;

public class Customer
{
    public string CustomerName { get; set; }
    private string BankPin;
    public Guid AccountNumber { get; set; }
    public Guid BankCode { get; set; }
    public double AccountBalance { get; set; } = 0D;

    public Customer(string Name, Bank ChoiceBank, string PIN)
    {
        CustomerName = Name;
        BankCode = ChoiceBank.GetCBNCode();
        BankPin = PIN;
    }

    public void DepositMoney (double amount)
    {
        AccountBalance += amount;
    }
    public void AboutCustomer (string? pin = null)
    {
        if (pin != null)
        {
            if (pin != BankPin)
            {
                throw new InvalidPinException("Access Denied: Incorrect PIN");
            }
            Console.WriteLine(@$"This customer's name is {CustomerName} making use of {Bank.GetNameFromCBNId(BankCode)}
With an account Balance of {AccountBalance} and PIN: {BankPin}");
        }
        else
        {
            Console.WriteLine(@$"This customer's name is {CustomerName} making use of {Bank.GetNameFromCBNId(BankCode)}
With an account Balance of {AccountBalance} and PIN: {new string('*', BankPin.Length)}");
        }
    }
}
