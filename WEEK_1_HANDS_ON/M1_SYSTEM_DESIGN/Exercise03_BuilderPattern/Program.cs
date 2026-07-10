using System;

class Computer
{
    public string CPU;
    public string RAM;
    public string Storage;

    private Computer(Builder builder)
    {
        CPU = builder.CPU;
        RAM = builder.RAM;
        Storage = builder.Storage;
    }

    public void Display()
    {
        Console.WriteLine("Computer Configuration");
        Console.WriteLine("CPU     : " + CPU);
        Console.WriteLine("RAM     : " + RAM);
        Console.WriteLine("Storage : " + Storage);
        Console.WriteLine();
    }

    public class Builder
    {
        public string CPU;
        public string RAM;
        public string Storage;

        public Builder SetCPU(string cpu)
        {
            CPU = cpu;
            return this;
        }

        public Builder SetRAM(string ram)
        {
            RAM = ram;
            return this;
        }

        public Builder SetStorage(string storage)
        {
            Storage = storage;
            return this;
        }

        public Computer Build()
        {
            return new Computer(this);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Computer gamingPC = new Computer.Builder()
            .SetCPU("Intel i9")
            .SetRAM("32 GB")
            .SetStorage("1 TB SSD")
            .Build();

        Computer officePC = new Computer.Builder()
            .SetCPU("Intel i5")
            .SetRAM("16 GB")
            .SetStorage("512 GB SSD")
            .Build();

        gamingPC.Display();
        officePC.Display();
    }
}
