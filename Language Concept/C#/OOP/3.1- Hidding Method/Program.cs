using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Xml.Linq;

class Program
{
    static void Main(String[] args)
    {
        FullEmployee employee = new FullEmployee();
        employee.PrintEmployee();

        // convert object from class to class.
        ((Employee)employee).PrintEmployee();
    }
}

public class Employee
{
    private int Id;
    private string FirstName;
    private string LastName;


    public int Id1 { get => Id; set => Id = value; }
    public string FirstName1 { get => FirstName; set => FirstName = value; }
    public string LastName1 { get => LastName; set => LastName = value; }


    public void PrintEmployee()
    {
        Console.WriteLine("Employee class");
    }
}


public class PartEmployee : Employee
{
    //hiding method in parent class (ignore it) and run method in child class --> used (new) keyword.
    public new  void PrintEmployee()
    {
        Console.WriteLine("PartEmployee class");
    }

}

public class FullEmployee : PartEmployee
{
    //hiding method
    public new void PrintEmployee()
    {
        Console.WriteLine("FullEmployee class");
    }

}