using Microsoft.AspNetCore.Mvc;
using MongoDB.Practics.API.Controllers.Base;
using MongoDB.Practics.Data.Core;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.API.Controllers
{
    [ApiController]
    [Route("CategoriesAPI/v1/[controller]")]
    public class CategoriesController : BaseController<Categories>
    {
        public CategoriesController(ICategoriesCore repository, ILogger<Categories> logger) : base(repository, logger)
        {
        }
    }
}
