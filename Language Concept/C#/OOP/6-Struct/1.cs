using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Xml.Linq;

class Program
{
    static void Main(String[] args)
    {
        //First Way
        Customer one = new Customer(5, "Ahmed");
        one.printDetails();

        //Second Way
        Customer two = new Customer();
        two.Id = 1;
        two.Name = "Ali";
        two.printDetails();

        //Third Way
        Customer three = new Customer
        {
            Id = 2,
            Name = "Taha"
        };
        three.printDetails();
    }

}

//struct 
public struct Customer
{
    private int _id;
    private string _name;

    public int Id { get => _id; set => _id = value; }
    public string Name { get => _name; set => _name = value; }

    public Customer(int id, string name)
    {
        this._id = id;
        this._name = name;
    }

    public void printDetails()
    {
        Console.WriteLine("ID = {0} \n Name = {1}", Id, Name);
    }

}
