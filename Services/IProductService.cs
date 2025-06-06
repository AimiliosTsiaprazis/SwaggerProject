using System;
using SwaggerProject.Modells;
using System.Collections.Generic;

public interface IProductService
{
    List<Product> GetProducts();
    void Add(Product product);
}