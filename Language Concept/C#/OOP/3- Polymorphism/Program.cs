using System;
class Program
{
    static void Main(String[] args)
    {

        Employee E = new Employee();
        E.GetInfo();

    }
}

public class Person
{
    protected string ssn = "444-55-6666";
    protected string name = "Ahmed Shalash";

    public virtual void GetInfo()
    {
        Console.WriteLine("Name: {0}", name);
        Console.WriteLine("SSN: {0}", ssn);
    }
}
class Employee : Person
{
    public string id = "ABC567EFG";
    public override void GetInfo()
    {
        // Calling the base class GetInfo method:
        base.GetInfo();
        Console.WriteLine("Employee ID: {0}", id);
    }
}
