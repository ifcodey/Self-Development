using System;
class Program
{
    static void Main(String[] args)
    {
        FullTimeEmployee full = new FullTimeEmployee();
        PartTimeEmployee part = new PartTimeEmployee();

        full.FirstName = "Ahmed";
        full.LastName = "Shalash";
        full.PrintSalary(256, 25);
        full.PrintFullName();

        part.FirstName = "Mohammand";
        part.LastName = "Shalash";
        part.PrintSalary(256, 25, 5);
        part.PrintFullName();
    }
}

public class Empolyee
{
    public string FirstName;
    public string LastName;
    public float HourlySalary;
    public float Hours;
    public void PrintFullName()
    {
        Console.WriteLine("The User Full Name is : {0}\n", (FirstName + " " + LastName));
    }
}

public class FullTimeEmployee : Empolyee
{
    public float TotalSalary(int days, int HourlySalary)
    {
        return days * HourlySalary * 8;
    }

    public void PrintSalary(int days, int HourlySalary)
    {
        Console.WriteLine("The Full Time Salary in Year : {0}", TotalSalary(days, HourlySalary));
    }
}

public class PartTimeEmployee : Empolyee
{
    public float TotalSalary(int days, int HourlySalary, int Hours)
    {
        return days * HourlySalary * Hours;
    }

    public void PrintSalary(int days, int HourlySalary, int Hours)
    {
        Console.WriteLine("The Part Time Salary in Year : {0}", TotalSalary(days, HourlySalary, Hours));
    }
}