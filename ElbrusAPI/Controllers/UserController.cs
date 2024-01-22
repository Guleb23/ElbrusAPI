using ElbrusAPI.Database;
using ElbrusAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Localization;

namespace ElbrusAPI.Controllers
{
    [Route("ElbrusAPI[Controller]")]
    [ApiController]
    public class UserController : Controller
    {

        private readonly ApplicationDBContext dbContext;
        public UserController(ApplicationDBContext _context)
        {
            dbContext = _context;
            
        }
        [HttpGet]
        public List<WorkerModel> GetWorkerModel()
        {
            return dbContext.Worker.ToList();
        }
    }
}
