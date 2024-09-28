using ASPNetCoreDesignPatterns.Patterns.Creational.Singleton;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreDesignPatterns.Controllers.Creational
{
    [Route("Creational/[controller]/[action]")]
    [ApiController]
    public class SingletonController : ControllerBase
    {
        private readonly Singleton _singleton;

        public SingletonController(Singleton singleton)
        {
            _singleton = singleton;
        }

        [HttpGet]
        public IActionResult GetCurrentCounter()
        {
            return Ok(_singleton.GetCounter());
        }

        [HttpPost]
        public IActionResult IncrementCounter()
        {
            _singleton.IncrementCounter();
            return Ok("Counter incremented");
        }
    }
}
