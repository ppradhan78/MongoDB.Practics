using Microsoft.AspNetCore.Mvc;
using MongoDB.Practics.API.Controllers.Base;
using MongoDB.Practics.Data.Core;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.API.Controllers
{
    [ApiController]
    [Route("RegionAPI/v1/[controller]")]
    public class RegionController : BaseController<Region>
    {
        public RegionController(IRegionCore repository, ILogger<Region> logger) : base(repository, logger)
        {
        }
    }
}
