namespace OopDemo;

public class Vendor : IPayable
{
    public string CompanyName { get; set; } = String.Empty;

    public void PayMoney()
    {
        Console.WriteLine($"Vendor paid");
    }
}
