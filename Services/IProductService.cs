using System;
using SwaggerProject.Modells;
using System.Collections.Generic;

public interface IProductService
{
    Task AddAsync(Product product);
    List<Product> GetProducts();
}