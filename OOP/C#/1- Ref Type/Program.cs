using System;
class Program
{
    static void Main(String[] args)
    {
        try
        {
            bool? Major = Boolean.Parse(Console.ReadLine());
            if (Major == true) Console.WriteLine("User is major");
            else if (!Major.Value) Console.WriteLine("User is not major");
            else Console.WriteLine("User did not answer the question");
        }
        catch (Exception)
        {

            Console.WriteLine("User did not answer the question");
        }
       
    }

    //Value type - int/float/struct/enum. ---> 0 , "" , other.
    //Ref type - interface/class/delegate/arrays ---> null defualt value.


}