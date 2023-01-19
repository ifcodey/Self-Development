using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Xml.Linq;

//Explicit interface implementation -> when the method have a same name and two interface are inherte to same class and you want to call it.
class Program : _Iface, _Iface2
{
    //without access modifier -> public. to convert to explicit interface to this method.
    void _Iface.InterFaceMethod()
    {
        Console.WriteLine("Interface _Iface Method.");
    }

    void _Iface2.InterFaceMethod()
    {
        Console.WriteLine("Interface _Iface2 Method.");
    }
    static void Main(String[] args)
    {
        Program p = new Program();
        //type cast operator.
        ((_Iface)p).InterFaceMethod();
        ((_Iface2)p).InterFaceMethod();

        Console.WriteLine("-------------------------");
        //or
        _Iface i1 = new Program();
        _Iface2 i2 = new Program();
        i1.InterFaceMethod();
        i2.InterFaceMethod();
    }

}

interface _Iface
{
    void InterFaceMethod();
}

interface _Iface2
{
    void InterFaceMethod();
}
