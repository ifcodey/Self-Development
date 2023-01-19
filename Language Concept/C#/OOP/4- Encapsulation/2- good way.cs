using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Xml.Linq;

class Program
{
    static void Main(String[] args)
    {
        Student student = new Student();
        student.id = 1;
        student.name = "test";
        student.email = "test@gmail.com";
        student.phone = "0598527415";

        Console.WriteLine("{0}\n{1}\n{2}\n{3}", student.id, student.name, student.email, student.phone);


    }


}

public class Student
{
    private int _id;
    private string _name;
    private string _email;
    private string _phone;

    //Setter and Getter = properity.
    public int id
    {
        set
        {
            if (value <= 0)
            {
                throw new Exception("Student id should be greater than zero");
            }
            this._id = value;
        }
        get { return this._id; }
    }
    public string name
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Student name should be vaild not empty");
            }
            this._name = value;
        }
        get { return this._name; }
    }
    public string email
    {
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new Exception("Student email should be vaild");
            }
            this._email = value;
        }
        get { return this._email; }
    }
    public string phone
    {
        set
        {
            this._phone = value;
        }
        get { return this._phone; }
    }


}