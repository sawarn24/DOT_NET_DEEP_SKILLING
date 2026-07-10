using System;

interface IDocument
{
    void Open();
}

class WordDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Word Document Opened");
    }
}

class PdfDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("PDF Document Opened");
    }
}

class ExcelDocument : IDocument
{
    public void Open()
    {
        Console.WriteLine("Excel Document Opened");
    }
}

abstract class DocumentFactory
{
    public abstract IDocument CreateDocument();
}

class WordFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new WordDocument();
    }
}

class PdfFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new PdfDocument();
    }
}

class ExcelFactory : DocumentFactory
{
    public override IDocument CreateDocument()
    {
        return new ExcelDocument();
    }
}

class Program
{
    static void Main(string[] args)
    {
        DocumentFactory factory;

        factory = new WordFactory();
        IDocument word = factory.CreateDocument();
        word.Open();

        factory = new PdfFactory();
        IDocument pdf = factory.CreateDocument();
        pdf.Open();

        factory = new ExcelFactory();
        IDocument excel = factory.CreateDocument();
        excel.Open();
    }
}
