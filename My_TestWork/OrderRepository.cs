using My_TestWork.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace My_TestWork
{
    public class OrderRepository
    {
        private static List<Order> _orders;

        public OrderRepository()
        {
            _orders = new List<Order> { new Order { ID = 1, Number = "001", DateOfCreate = new DateTime(2018, 05, 10), DateOfShipment = new DateTime(2018, 05, 15), Manager = "Ivanov" } };
        }

        public async Task<List<Order>> GetOrders()
        {
            return await Task.Run(() => _orders);
        }

        public async Task<Order> GetOrder(int ID)
        {
            return await Task.Run(() => _orders.FirstOrDefault(f => f.ID == ID));
        }
    }
}