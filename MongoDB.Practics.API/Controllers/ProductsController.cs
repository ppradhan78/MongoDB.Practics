using Microsoft.AspNetCore.Mvc;
using MongoDB.Practics.API.Controllers.Base;
using MongoDB.Practics.Data.Core;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.API.Controllers
{
    [ApiController]
    [Route("ProductsAPI/v1/[controller]")]
    public class ProductsController : BaseController<Products>
    {
        public ProductsController(IProductsCore repository, ILogger<Products> logger) : base(repository, logger)
        {
        }
    }
}
