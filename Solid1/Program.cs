using System;
using System.Collections.Generic;

namespace Solid1;

class Item
{

}

class PriceCalculator
{
    public void CalculateTotalSum(List<Item> items) {/*...*/}
}
class Order
{
    public IList<Item> ItemList { get; set; }

    public Order()
    {
        ItemList = new List<Item>();
    }

    public Order(IList<Item> list)
    {
        ItemList = list;
    }

    public void GetItems() {/*...*/}
    public void GetItemCount() {/*...*/}
    public void AddItem(Item item) {/*...*/}
    public void DeleteItem(Item item) {/*...*/}


}

class OrderDisplayer
{

    public void PrintOrder(Order order) {/*...*/}
    public void ShowOrder(Order order) {/*...*/}
}

class StorageManager
{

    public void LoadOrder(Order order) {/*...*/}
    public void SaveOrder(Order order) {/*...*/}
    public void UpdateOrder(Order order) {/*...*/}
    public void DeleteOrder(Order order) {/*...*/}
}

class Program
{
    static void Main()
    {
    }
}
