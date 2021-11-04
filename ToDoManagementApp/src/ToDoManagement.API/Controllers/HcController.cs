using Microsoft.AspNetCore.Mvc;

namespace ToDoManagement.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HcController : ControllerBase
    {
        [HttpGet]
        public string Get()
        {
            return "Healthy";
        }
    }
}
