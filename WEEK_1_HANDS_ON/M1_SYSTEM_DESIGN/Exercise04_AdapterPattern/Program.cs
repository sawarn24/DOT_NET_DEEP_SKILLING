using System;

interface IPaymentProcessor
{
    void ProcessPayment(double amount);
}

class PayPalGateway
{
    public void MakePayment(double amount)
    {
        Console.WriteLine("Payment of Rs. " + amount + " processed through PayPal.");
    }
}

class StripeGateway
{
    public void Pay(double amount)
    {
        Console.WriteLine("Payment of Rs. " + amount + " processed through Stripe.");
    }
}

class PayPalAdapter : IPaymentProcessor
{
    private PayPalGateway paypal = new PayPalGateway();

    public void ProcessPayment(double amount)
    {
        paypal.MakePayment(amount);
    }
}

class StripeAdapter : IPaymentProcessor
{
    private StripeGateway stripe = new StripeGateway();

    public void ProcessPayment(double amount)
    {
        stripe.Pay(amount);
    }
}

class Program
{
    static void Main(string[] args)
    {
        IPaymentProcessor payment;

        payment = new PayPalAdapter();
        payment.ProcessPayment(2500);

        payment = new StripeAdapter();
        payment.ProcessPayment(4500);
    }
}
