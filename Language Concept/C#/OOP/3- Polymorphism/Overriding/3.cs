using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Xml.Linq;

class Program
{
    static void Main(String[] args)
    {
        Employee [] employee = new Employee[4];
        employee[0] = new Employee();
        employee[1] = new partEmp();
        employee[2] = new fullEmp();
        employee[3] = new temporaryEmp();

        foreach (Employee emp in employee)
        {
            emp.PrintFun();
        }
    }
}

public class Employee
{
    public string Fname = "Fn";
    public string Lname = "Ln";
    public virtual void PrintFun()
    {
        Console.WriteLine(Fname + " " + Lname);
    }
}

public class partEmp : Employee
{
    public override void PrintFun()
    {
        Console.WriteLine(Fname + " " + Lname + "- part time Emp");
    }
}

public class fullEmp : Employee
{
    public override void PrintFun()
    {
        Console.WriteLine(Fname + " " + Lname + "- full time Emp");
    }
}

public class temporaryEmp : Employee
{
    public override void PrintFun()
    {
        Console.WriteLine(Fname + " " + Lname + "- temporary time Emp");
    }
}