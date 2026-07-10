using System;

interface ICustomerRepository
{
    void FindCustomerById(int id);
}

class CustomerRepositoryImpl : ICustomerRepository
{
    public void FindCustomerById(int id)
    {
        Console.WriteLine("Customer Found with ID: " + id);
    }
}

class CustomerService
{
    private ICustomerRepository repository;

    public CustomerService(ICustomerRepository repository)
    {
        this.repository = repository;
    }

    public void GetCustomer(int id)
    {
        repository.FindCustomerById(id);
    }
}

class Program
{
    static void Main(string[] args)
    {
        ICustomerRepository repository = new CustomerRepositoryImpl();

        CustomerService service = new CustomerService(repository);

        service.GetCustomer(101);
    }
}