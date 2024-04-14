using Microsoft.AspNetCore.Mvc;
using MongoDB.Practics.API.Controllers.Base;
using MongoDB.Practics.Data.Core;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.API.Controllers
{
    [ApiController]
    [Route("ShippersAPI/v1/[controller]")]
    public class ShippersController : BaseController<Shippers>
    {
        public ShippersController(IShippersCore repository, ILogger<Shippers> logger) : base(repository, logger)
        {
        }
    }
}
