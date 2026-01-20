namespace BankAppIllustration;

public class Bank
{
    public string BankName { get; set; }
    private Guid CBN_Id { get; }
    public decimal TotalAssets { get; set; }
    private static List<Bank> Banks = new();

    public Bank(string bankName)
    {
        BankName = bankName;
        CBN_Id = Guid.NewGuid();
        TotalAssets = 0;
        Banks.Add(this);
    }
    public static List<string>? GetAllBanks()
    {
        return Banks.Select(u => u.BankName).ToList();
    }

    public Guid GetCBNCode()
    {
        return CBN_Id;
    }
    public static string GetNameFromCBNId (Guid CBN_Id)
    {
        return Banks.Find(b => b.CBN_Id == CBN_Id).BankName;
    }
}
