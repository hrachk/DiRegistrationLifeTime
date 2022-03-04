using DiRegistrationLifeTime.Services;
using DiRegistrationLifeTime.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DiRegistrationLifeTime.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
        private readonly ISingletonService singletonService;
        private readonly IScopedService scopedService;
        private readonly ITransientService transientService;
        private readonly DatabaseService databaseService;

        public TestController(
            ISingletonService singletonService,
            IScopedService scopedService,
            ITransientService transientService,
            DatabaseService databaseService)
        {
            this.singletonService = singletonService;
            this.scopedService = scopedService;
            this.transientService = transientService;
            this.databaseService = databaseService;
        }


        [HttpGet]
        [Route("GetDIs")]
        public IActionResult Get()
        {
            Console.WriteLine("\n|||||||||||| TestController ||||||||\n");
            Console.WriteLine($"Singleton UID:\t\t{singletonService.ServiceUniqueIdentifier}");
            Console.WriteLine($"Scoped UID:\t\t{scopedService.ServiceUniqueIdentifier}");
            Console.WriteLine($"Transient UID:\t\t{transientService.ServiceUniqueIdentifier}");
            databaseService.SaveData();

            return Ok();
        }

        [HttpPost]
        [Route("Post")]
        public IActionResult Post()
        {
            Console.WriteLine("\n|||||||||||| TestController ||||||||\n");
            Console.WriteLine($"Singleton UID:\t\t{singletonService.ServiceUniqueIdentifier}");
            Console.WriteLine($"Scoped UID:\t\t{scopedService.ServiceUniqueIdentifier}");
            Console.WriteLine($"Transient UID:\t\t{transientService.ServiceUniqueIdentifier}");
            return Ok();
        }

        [HttpPut]
        [Route("Pust")]
        public IActionResult Update()
        {
            Console.WriteLine("\n|||||||||||| TestController ||||||||\n");
            Console.WriteLine($"Singleton UID:\t\t{singletonService.ServiceUniqueIdentifier}");
            Console.WriteLine($"Scoped UID:\t\t{scopedService.ServiceUniqueIdentifier}");
            Console.WriteLine($"Transient UID:\t\t{transientService.ServiceUniqueIdentifier}");
            return Ok();
        }

        [HttpDelete]
        [Route("Delete")]
        public IActionResult Delete()
        {
            Console.WriteLine("\n|||||||||||| TestController ||||||||\n");
            Console.WriteLine($"Singleton UID:\t\t{singletonService.ServiceUniqueIdentifier}");
            Console.WriteLine($"Scoped UID:\t\t{scopedService.ServiceUniqueIdentifier}");
            Console.WriteLine($"Transient UID:\t\t{transientService.ServiceUniqueIdentifier}");
            return Ok();
        }

    }
}
