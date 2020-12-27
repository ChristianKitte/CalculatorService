using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using HelloWorldService.Models;

namespace HelloWorldService.Controllers
{
    [Route("Calculator")]
    [ApiController]
    public class CalculatorController : ControllerBase
    {
        public CalculatorController()
        {
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<string> GetStandardValue()
        {
            HttpContext.Response.StatusCode = StatusCodes.Status404NotFound;
            return "Es wurde kein Wert übergeben";
        }
        
        [HttpGet("{values}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<string> GetReturnValue(string values)
        {
            HttpContext.Response.StatusCode = StatusCodes.Status200OK;
            return values;
        }
    }
}