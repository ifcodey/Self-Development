using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Xml.Linq;

class Program
{
    static void Main(String[] args)
    {
        Icustomer customer = null;
        customer = new Customer();

        //Uncorrect way.

        //Icustomer customer = null;
        //customer = new Icustomer();
        customer.print();

        Customers customers = new Customers();
        customers.print();
    }
}

// 1- can't have a definition of method as class | 2- can't have a access modifier | 3- can't have a field.
interface Icustomer
{
    void print();
}

interface Iseller
{
    void printer();
}

public class Customer : Icustomer, Iseller
{
    public void print()
    {
        Console.WriteLine("print interfae Icustomer from class.");
    }

    public void printer()
    {
        Console.WriteLine("print interfae Iseller from class.");
    }
}

public struct Customers : Icustomer
{
    public void print()
    {
        Console.WriteLine("print interfae method from struct.");
    }
}
