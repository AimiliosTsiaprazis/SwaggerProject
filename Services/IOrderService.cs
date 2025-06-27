using System;
using SwaggerProject.Modells;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IOrderService
{
    Task AddAsync(Order order);
    List<Order> GetOrders();
}