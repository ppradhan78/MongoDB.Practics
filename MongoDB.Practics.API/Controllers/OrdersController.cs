using Microsoft.AspNetCore.Mvc;
using MongoDB.Practics.API.Controllers.Base;
using MongoDB.Practics.Data.Core;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.API.Controllers
{
    [ApiController]
    [Route("OrdersAPI/v1/[controller]")]
    public class OrdersController : BaseController<Orders>
    {
        public OrdersController(IOrdersCore repository, ILogger<Orders> logger) : base(repository, logger)
        {
        }
    }
}
