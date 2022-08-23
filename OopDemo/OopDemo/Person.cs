namespace OopDemo;

public abstract class Person : IPayable
{
    public string FirstName { get; set; } = String.Empty;
    public string LastName { get; set; } = String.Empty;

    public virtual string FullName => $"{FirstName} {LastName}";

    public abstract void PayMoney();
}
