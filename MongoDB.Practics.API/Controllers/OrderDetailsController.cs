using Microsoft.AspNetCore.Mvc;
using MongoDB.Practics.API.Controllers.Base;
using MongoDB.Practics.Data.BusinessObjects;
using MongoDB.Practics.Data.Core;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.API.Controllers
{
    [ApiController]
    [Route("OrderDetailsAPI/v1/[controller]")]
    public class OrderDetailsController : BaseController<OrderDetails>
    {
        public OrderDetailsController(OrderDetailsCore repository, ILogger<OrderDetails> logger) : base(repository, logger)
        {
        }
    }
}
