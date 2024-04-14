using Microsoft.AspNetCore.Mvc;
using MongoDB.Practics.API.Controllers.Base;
using MongoDB.Practics.Data.Core;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.API.Controllers
{
    [ApiController]
    [Route("CustomersAPI/v1/[controller]")]
    public class CustomersController : BaseController<Customers>
    {
        public CustomersController(ICustomersCore repository, ILogger<Customers> logger) : base(repository, logger)
        {
        }
    }
}
