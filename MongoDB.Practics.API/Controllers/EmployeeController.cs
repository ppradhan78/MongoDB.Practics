using Microsoft.AspNetCore.Mvc;
using MongoDB.Practics.API.Controllers.Base;
using MongoDB.Practics.Data.Core;
using MongoDB.Practics.Data.Entities;

namespace MongoDB.Practics.API.Controllers
{
    [ApiController]
    [Route("EmployeeAPI/v1/[controller]")]
    public class EmployeeController : BaseController<EmployeeEntity>
    {
        public EmployeeController(IEmployeeCore repository, ILogger<EmployeeEntity> logger) : base(repository, logger)
        {
        }
    }
}
