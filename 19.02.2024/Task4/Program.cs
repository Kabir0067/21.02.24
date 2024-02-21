var User = new Employee();
Console.Write("Enter employee's First Name: ");
User.FirstName = Console.ReadLine();

Console.Write("Enter employee's Last Name: ");
User.LastName = Console.ReadLine();

Console.Write("Enter employee's Age: ");
User.Age = int.Parse(Console.ReadLine());

Console.Write("Enter employee's Position: ");
User.Position = Console.ReadLine();

Console.Write("Enter employee's Salary: ");
User.SetSalary(decimal.Parse(Console.ReadLine()));

System.Console.WriteLine("\n___________________________________________");

Console.WriteLine($"\n{User.GetInfo()}");

System.Console.WriteLine("___________________________________________");

System.Console.Write("\nSet a new Salary:");
System.Console.WriteLine(User.GetSalary());

System.Console.WriteLine("\n___________________________________________");



Console.WriteLine(User.GetInfo());


public class Employee
{
    public string FirstName;
    public string LastName;
    public int Age;
    public string Position;
    public decimal Salary;

    public void SetSalary(decimal salary)
    {
        Salary = salary;
    }

    public decimal GetSalary()
    {
        return Salary + 5000;
    }

    public string GetInfo()
    {
        return $"First Name: {FirstName}\nLast Name: {LastName}\nAge: {Age}\nPosition: {Position}\nSalary: {Salary:C}";
    }
}