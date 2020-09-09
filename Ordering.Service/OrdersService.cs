using Microsoft.Azure.Cosmos;
using Ordering.Data.Repositories;
using Ordering.Model;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Ordering.Service
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            
            _orderRepository = orderRepository;
        }
        public async Task<Order> AddNewOrder(Order order)
        {
            await _orderRepository.AddItemAsync(order);
            return order;
        }
        public async Task<Order> GetOrderById(string orderId)
        {
            return await _orderRepository.GetItemAsync(orderId);
        }
    }

    public interface IOrderService
    {
        Task<Order> AddNewOrder(Order order);
        Task<Order> GetOrderById(string orderId);
    }
}
