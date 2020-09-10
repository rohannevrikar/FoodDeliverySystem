using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Cosmos;
using Newtonsoft.Json;
using Ordering.Data.Repositories;
using Ordering.Model;
using Ordering.Service;

namespace Ordering.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IOrderService _orderService;
        public OrdersController(IOrderService orderService)
        {
            _orderService = orderService;
        }

        [Route("neworder")]
        [HttpPost]
        public async Task<string> PlaceNewOrder([FromBody]Order order)
        {            
            return JsonConvert.SerializeObject(await _orderService.AddNewOrder(order));
        }

        [Route("{orderId:Guid}")]
        [HttpGet]
        public async Task<string> GetOrder(string orderId)
        {
            return JsonConvert.SerializeObject(await _orderService.GetOrderById(orderId));
        }

       
    }
}