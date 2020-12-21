using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelloWorldService.Models;

namespace HelloWorldService.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        public HelloWorldController()
        {   
        }

        [HttpGet]
        public string GetReturnValue()
        {
            return "Der Wert ist super";
        }
    }
}
