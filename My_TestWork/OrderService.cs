using My_TestWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace My_TestWork
{
    public class OrderService
    {
        private readonly OrderRepository _orderRepository;

        public OrderService()
        {
            _orderRepository = new OrderRepository();
        }

        public async Task<List<Order>> GetOrders()
        {
            return await _orderRepository.GetOrders();
        }
    }
}