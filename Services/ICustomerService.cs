using System;
using SwaggerProject.Modells;
using System.Collections.Generic;

public interface ICustomerService
{
    Task AddAsync(Customer customer);
    List<Customer> GetCustomers();
}