using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SimpleInjectorWebAPIDemo.Controllers
{
    [Route("api/[controller]")]
    public class HelloController : Controller
    {
        private IHelloWorldService _helloService;

        public HelloController(IHelloWorldService helloService)
        {
            _helloService = helloService;
        }

        [HttpGet]
        public string Get()
        {
            return _helloService.HelloWorld();
        }
    }
}
