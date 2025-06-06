using System;
using SwaggerProject.Modells;
using System.Collections.Generic;

public class CustomerService : ICustomerService
{
    public readonly List<Customer> _customers = new();
    public List<Customer> GetCustomers() => _customers;
    public void Add(Customer customer)
    {
        customer.Id = _customers.Count + 1;
        _customers.Add(customer);
    }
}