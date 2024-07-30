using ECommerceAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

public interface IOrderService
{
    Task<IEnumerable<Order>> GetOrdersByUserIdAsync(int userId);
    Task<Order> GetOrderByIdAsync(int id);
    Task AddOrderAsync(Order order);
}
