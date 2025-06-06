using System;
using SwaggerProject.Modells;

public class OrderService : IOrderService
{
    public readonly List<Order> _orders = new();
    public List<Order> GetOrders() => _orders;
    public void Add(Order order)
    {
        order.Id = _orders.Count + 1;
        _orders.Add(order);
    }
}