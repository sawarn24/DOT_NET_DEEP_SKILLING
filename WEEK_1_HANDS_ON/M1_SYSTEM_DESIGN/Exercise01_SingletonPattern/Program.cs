using System;

class Logger
{
    private static Logger instance;

    private Logger()
    {
        Console.WriteLine("Logger Instance Created");
    }

    public static Logger GetInstance()
    {
        if (instance == null)
        {
            instance = new Logger();
        }

        return instance;
    }

    public void Log(string message)
    {
        Console.WriteLine("Log: " + message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        Logger logger1 = Logger.GetInstance();
        logger1.Log("Application Started");

        Logger logger2 = Logger.GetInstance();
        logger2.Log("User Logged In");

        if (logger1 == logger2)
        {
            Console.WriteLine("\nOnly one Logger instance exists.");
        }
    }
}
