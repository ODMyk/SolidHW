using System;

namespace Solid4;

interface IItem
{
    void ApplyDiscount(String discount);
    void ApplyPromocode(String promocode);

    void SetColor(byte color);
    void SetSize(byte size);

    void SetPrice(double price);
}

class Program
{
    static void Main(string[] args)
    {
    }
}