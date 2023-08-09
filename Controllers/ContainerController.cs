using ContainerPOC.Repository;
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
        public decimal Get()
        {
            var logicRepo = new LogicalRepository();
            logicRepo.getCalculations(10, 30);
            return logicRepo.getCalculations(40, 30);
        }
    }
}