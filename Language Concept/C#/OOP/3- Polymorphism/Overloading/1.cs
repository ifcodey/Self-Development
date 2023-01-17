using System;
using System.Net;
using System.Runtime.InteropServices;
using System.Xml.Linq;

class Program
{
    static void Main(String[] args)
    {
        Add(1.1F, 1.2F);
        float x = Add(1, 1.1F);
        Console.WriteLine("The Return Function Sum {0}", x);
        Add(1, 1);
        Add(2, 1, 1);
    }
    //OverLoading
    // 1- change type param.
    // 2- number of param.
    // 3- type of param related (out , ref , normal param - value param)
    public static void Add(int FN, int LN)
    {
        Console.WriteLine("Sum ={0} ", FN + LN);
    }

    public static void Add(float FN, float LN)
    {
        Console.WriteLine("Sum ={0} ", FN + LN);
    }

    public static float Add(int FN, float LN)
    {
        return FN + LN;
    }

    public static void Add(int FN, int SN, int TN)
    {
        Console.WriteLine("Sum ={0} ", FN + SN + TN);
    }
}
