namespace OopDemo;

public class Customer : Person, IPayable
{
    public override void PayMoney()
    {
        Console.WriteLine("Customer paid");
    }
}
