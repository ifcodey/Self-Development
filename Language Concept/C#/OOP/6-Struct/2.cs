using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Xml.Linq;

class Program
{
    static void Main(String[] args)
    {

        int i = 10;
        if (i == 10)
        {
            int j = 20;
            Customer customer = new Customer();
            customer.Id = 101;
            customer.Name = "test";
        }
    }

}

//struct vs class
//struct - 1- don't have a destructor | 2- value type but class ref type | 3- store in stack but class in heap |
// 4- don't have non-param constructor in struct mean should have param constructor | 5- can't inherit from another class/struct.
//6- struct consider a sealed  so no inherit from class {just from interface can inherit}.
public struct Customer
{
    private int id;
    private string name;

    public int Id { get => id; set => id = value; }
    public string Name { get => name; set => name = value; }
}
