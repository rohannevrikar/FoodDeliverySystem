using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Ordering.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrdersController : ControllerBase
    {
        [Route("activeOrders")]
        public IActionResult GetActiveOrder(int userId)
        {
            return Ok(userId);
        }
    }
}