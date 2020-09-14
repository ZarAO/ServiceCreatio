using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Mvc;

namespace My_TestWork.Controllers
{
    public class OrdersController : Controller
    {
        private readonly OrderService _orderService;

        public OrdersController()
        {
            _orderService = new OrderService();
        }

        public async Task<ActionResult> Index()
        {
            var order = await _orderService.GetOrders();
            return View(order);
        }

        public ActionResult AddOrder()
        {
            return View();
        }

        public ActionResult EditOrder()
        {
            return View();
        }
    }
}
