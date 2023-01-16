using System;
class Program
{
    static void Main(String[] args)
    {
        Circle C1 = new Circle(5);
        float  Area1 = C1.CalculateArea();
        Console.WriteLine("Area = {0}",Area1);

        Circle C2 = new Circle(6);
        float Area2 = C2.CalculateArea();
        Console.WriteLine("Area = {0}", Area2);
    }
}

class Circle
{
    public static float _PI;
    int _Radius;
    static Circle()
    {
        _PI = 3.14f;
    }

    public Circle( int radius)
    {
        _Radius = radius;
    }
    public float CalculateArea()
    {
        return _Radius * Circle._PI;
    }
}
  