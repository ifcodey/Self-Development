using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Xml.Linq;

class Program
{
    static void Main(String[] args)
    {
        Student student = new Student();
        student.setID(1);
        student.setName("test");
        student.setEmail("test@gmail.com");
        student.setPhone("0598527415");

        Console.WriteLine("{0}\n{1}\n{2}\n{3}", student.getId(), student.getName(), student.getEmail(), student.getPhone());


    }


}

public class Student
{
    private int _id;
    private string _name;
    private string _email;
    private string _phone;

    //Setter.
    public void setID(int id)
    {
        if (id <= 0)
        {
            throw new Exception("Student id should be greater than zero");
        }
        this._id = id;
    }
    public void setName(string name)
    {
        if (string.IsNullOrEmpty(name))
        {
            throw new Exception("Student name should be vaild not empty");
        }
        this._name = name;
    }
    public void setEmail(string email)
    {
        if (string.IsNullOrEmpty(email))
        {
            throw new Exception("Student email should be vaild");
        }
        this._email = email;
    }
    public void setPhone(string phone)
    {
        this._phone = phone;
    }

    //Getter.
    public int getId()
    {
        return this._id;
    }
    public string getName()
    {
        return this._name;
    }
    public string getEmail()
    {
        return this._email;

    }
    public string getPhone()
    {
        return this._phone;
    }

}