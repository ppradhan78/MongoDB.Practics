using Microsoft.AspNetCore.Mvc;
using MongoDB.Practics.API.Controllers.Base;
using MongoDB.Practics.Data.Core;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.API.Controllers
{
    [ApiController]
    [Route("SuppliersAPI/v1/[controller]")]
    public class SuppliersController : BaseController<Suppliers>
    {
        public SuppliersController(ISuppliersCore repository, ILogger<Suppliers> logger) : base(repository, logger)
        {
        }
    }
}
