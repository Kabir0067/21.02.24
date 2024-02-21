var Person1 = new Person();
System.Console.Write("Enter your FirstName: ");
Person1.FirstName = Console.ReadLine();
System.Console.Write("Enter Your LastName:");
Person1.LastName = Console.ReadLine();
System.Console.Write("Enter your Age:");
Person1.Age = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("______________________________");
Person1.GetInfo();
public class Person
{
    public string FirstName;
    public string LastName;
    public int Age;

    public void GetInfo()
    {
        System.Console.WriteLine($"FirstName: {FirstName}");
        System.Console.WriteLine($"LastName: {LastName}");
        System.Console.WriteLine($"Age: {Age}");
    }
}
