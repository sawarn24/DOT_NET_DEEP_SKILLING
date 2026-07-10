using System;

interface IPaymentStrategy
{
    void Pay(double amount);
}

class CreditCardPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine("Paid Rs. " + amount + " using Credit Card.");
    }
}

class PayPalPayment : IPaymentStrategy
{
    public void Pay(double amount)
    {
        Console.WriteLine("Paid Rs. " + amount + " using PayPal.");
    }
}

class PaymentContext
{
    private IPaymentStrategy paymentStrategy;

    public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
    {
        this.paymentStrategy = paymentStrategy;
    }

    public void MakePayment(double amount)
    {
        paymentStrategy.Pay(amount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        PaymentContext context = new PaymentContext();

        context.SetPaymentStrategy(new CreditCardPayment());
        context.MakePayment(2500);

        context.SetPaymentStrategy(new PayPalPayment());
        context.MakePayment(1500);
    }
}
