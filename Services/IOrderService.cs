using System;
using SwaggerProject.Modells;
using System.Collections.Generic;

public interface IOrderService
{
    List<Order> GetOrders();
    void Add(Order order);
}