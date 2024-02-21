


var p = new Person();
System.Console.Write("Enter your firstname: ");
p.FirstName = Console.ReadLine();
p.LastName = Console.ReadLine();
p.Age = Convert.ToInt32(Console.ReadLine());

p.GetInfo();



// naqsha
public class Person
{
    public string FirstName; 
    public string LastName;
    public int Age;

    public void GetInfo()
    {
        System.Console.WriteLine($"FirstName: {FirstName}  LastName: {LastName}  Age: {Age}");
    }
}
