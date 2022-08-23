
using OopDemo;

var people = new List<IPayable>();

people.Add(new Customer() { FirstName = "Bill", LastName = "Gates" });
people.Add(new Employee() { FirstName = "Steve", LastName = "Jobs", Salary = 500000 });
people.Add(new Vendor() { CompanyName = "Acme" });

foreach (var p in people)
{
    p.PayMoney();
}
