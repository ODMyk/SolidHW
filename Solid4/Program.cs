using System;

namespace Solid4;

interface IPricable {
    void SetPrice(double price);
}

interface IColorable
{
    void SetColor(byte color);
}

interface ISizable {
    void SetSize(byte size);
}

interface IDiscountable {
    void ApplyDiscount(String discount);
}

interface IPromocodable {
    void ApplyPromocode(String promocode);
}

class Book : IPricable, IDiscountable
{
    public void ApplyDiscount(string discount)
    {
    }

    public void SetPrice(double price)
    {
    }
}

class Clothes : ISizable, IColorable, IPricable, IDiscountable
{
    public void ApplyDiscount(string discount)
    {
    }

    public void SetColor(byte color)
    {
    }

    public void SetPrice(double price)
    {
    }

    public void SetSize(byte size)
    {
    }
}

class Program
{
    static void Main(string[] args)
    {
    }
}