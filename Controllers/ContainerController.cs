using Microsoft.AspNetCore.Mvc;

namespace ContainerPOC.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContainerController : ControllerBase
    {
       

        private readonly ILogger<ContainerController> _logger;

        public ContainerController(ILogger<ContainerController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("test")]
        public string Get()
        {
            return "Mindsprint";
        }
    }
}