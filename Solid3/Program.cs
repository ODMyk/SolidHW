using System;

namespace Solid3;

interface IShape
{
    int GetArea();
}

class Rectangle : IShape
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }
    public int GetArea()
    {
        return Width * Height;
    }
}

class Square : IShape
{
    public int SideLength { get; set; }

    public int GetArea()
    {
        return SideLength * SideLength;
    }
}

class Program
{
    static void Main(string[] args)
    {
        IShape rect = new Square { SideLength = 10 };

        Console.WriteLine(rect.GetArea());
    }
}
