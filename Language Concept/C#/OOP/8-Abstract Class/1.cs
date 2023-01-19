using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Xml.Linq;

class Program : Customer
{
    static void Main(String[] args)
    {
        Program c = new Program();
        c.Print_unabstractMethod();
        c.print();
    }
}

public abstract class ACustomer
{
    public abstract void print();

    public void Print_unabstractMethod()
    {
        Console.WriteLine("unabstractMethod");
    }
}

// can't interface inherite from abstract class / normal class - just from other interface
// when iherite from abstact class should implement the method by used (override) but if abstract inherite from abstract no need to override.
// can't convert abstract to unherite with sealed beacuse should used inherite to implement a method.
public class Customer : ACustomer
{
    public override void print()
    {
        Console.WriteLine("print abstract method");
    }
}
