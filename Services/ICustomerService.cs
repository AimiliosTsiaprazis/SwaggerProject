using System;
using SwaggerProject.Modells;
using System.Collections.Generic;

public interface ICustomerService
{
    List<Customer> GetCustomers();
    void Add(Customer customer);
}