using System;
using System.Collections.Generic;

interface IObserver
{
    void Update(string stockName, double price);
}

interface IStock
{
    void Register(IObserver observer);
    void Deregister(IObserver observer);
    void NotifyObservers();
}

class StockMarket : IStock
{
    private List<IObserver> observers = new List<IObserver>();

    private string stockName;
    private double stockPrice;

    public void SetStock(string name, double price)
    {
        stockName = name;
        stockPrice = price;
        NotifyObservers();
    }

    public void Register(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Deregister(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void NotifyObservers()
    {
        foreach (IObserver observer in observers)
        {
            observer.Update(stockName, stockPrice);
        }
    }
}

class MobileApp : IObserver
{
    public void Update(string stockName, double price)
    {
        Console.WriteLine("Mobile App: " + stockName + " price updated to Rs. " + price);
    }
}

class WebApp : IObserver
{
    public void Update(string stockName, double price)
    {
        Console.WriteLine("Web App: " + stockName + " price updated to Rs. " + price);
    }
}

class Program
{
    static void Main(string[] args)
    {
        StockMarket stockMarket = new StockMarket();

        IObserver mobile = new MobileApp();
        IObserver web = new WebApp();

        stockMarket.Register(mobile);
        stockMarket.Register(web);

        stockMarket.SetStock("TCS", 3750);

        Console.WriteLine();

        stockMarket.SetStock("TCS", 3825);
    }
}