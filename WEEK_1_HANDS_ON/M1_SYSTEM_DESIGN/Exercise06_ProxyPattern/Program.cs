using System;

interface IImage
{
    void Display();
}

class RealImage : IImage
{
    private string fileName;

    public RealImage(string fileName)
    {
        this.fileName = fileName;
        LoadFromServer();
    }

    private void LoadFromServer()
    {
        Console.WriteLine("Loading " + fileName + " from remote server...");
    }

    public void Display()
    {
        Console.WriteLine("Displaying " + fileName);
    }
}

class ProxyImage : IImage
{
    private string fileName;
    private RealImage realImage;

    public ProxyImage(string fileName)
    {
        this.fileName = fileName;
    }

    public void Display()
    {
        if (realImage == null)
        {
            realImage = new RealImage(fileName);
        }

        realImage.Display();
    }
}

class Program
{
    static void Main(string[] args)
    {
        IImage image = new ProxyImage("Nature.jpg");

        Console.WriteLine("First Call:");
        image.Display();

        Console.WriteLine();

        Console.WriteLine("Second Call:");
        image.Display();
    }
}