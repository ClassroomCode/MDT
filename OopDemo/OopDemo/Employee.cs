namespace OopDemo;

public class Employee : Person, IPayable
{
    public double Salary { get; set; }

    public override string FullName => $"{LastName}, {FirstName}";

    public override void PayMoney()
    {
        Console.WriteLine($"{FullName} paid {Salary}");
    }
}
