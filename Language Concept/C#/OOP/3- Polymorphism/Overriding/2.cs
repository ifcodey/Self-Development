using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Xml.Linq;

class Program
{
    static void Main(String[] args)
    {
        FullEmployee employee = new FullEmployee();
        Console.WriteLine(employee.Salary(10,250,5000,26));
        Console.WriteLine(employee.Salary(20,260,28));
        employee.Name1 = "Test";
        Console.WriteLine(employee.Name1);
        employee.PrintEmployee();
    }
}

public class Employee
{
    private int Id;
    private string Name;
    private string FirstName;
    private string LastName;
    private string Title;
    private string Brand;
    private string Address;
    private string City;

    public int Id1 { get => Id; set => Id = value; }
    public string Name1 { get => Name; set => Name = value; }
    public string FirstName1 { get => FirstName; set => FirstName = value; }
    public string LastName1 { get => LastName; set => LastName = value; }
    public string Title1 { get => Title; set => Title = value; }
    public string Brand1 { get => Brand; set => Brand = value; }
    public string Address1 { get => Address; set => Address = value; }
    public string City1 { get => City; set => City = value; }

    public float Salary(int hourNumber, float days, float hourPrice)
    {
        return hourPrice * days * hourNumber;
    }
}


public class PartEmployee : Employee
{
    public PartEmployee() 
    {
        base.Id1 = 1;
        base.FirstName1 = "Ahmed";
        base.LastName1 = "Shalash";
        base.Title1 = "Naruto";
        base.Brand1 = "Anime";
        base.Address1 = "Japan";
        base.City1 = "Tokyo";
    }
    public void PrintEmployee()
    {
        Console.WriteLine("The First Name is : {0}" , FirstName1);
    }
    public new virtual float Salary(int hourNumber, float days, int bounis, float hourPrice)
    {
        return hourPrice * days * hourNumber + bounis;
    }
}

public class FullEmployee : PartEmployee
{
    public override float Salary(int hourNumber, float days, int bounis, float hourPrice)
    {
        return hourPrice * days * hourNumber + bounis + 100;
    }

}