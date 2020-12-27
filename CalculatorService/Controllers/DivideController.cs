using System;
using System.Globalization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculatorService.Controllers
{
    [Route("Divide")]
    [ApiController]
    public class DivideController : ControllerBase
    {
        public DivideController()
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
        
        [HttpGet("{wert1}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<string> GetReturn2Value(string wert1, string wert2)
        {
            try
            {
                HttpContext.Response.StatusCode = StatusCodes.Status200OK;
                return wert1.ToString(CultureInfo.CurrentCulture);
            }
            catch (Exception e)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status404NotFound;
                return "Es wurde kein Wert übergeben";
            }
        }
        
        [HttpGet("{wert1}/{wert2}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public ActionResult<string> GetReturn3Value(string wert1, string wert2)
        {
            try
            {
                double quotient = double.Parse(wert1) / double.Parse(wert2);
                HttpContext.Response.StatusCode = StatusCodes.Status200OK;
                return quotient.ToString(CultureInfo.CurrentCulture);
            }
            catch (Exception e)
            {
                HttpContext.Response.StatusCode = StatusCodes.Status404NotFound;
                return "Es wurde kein Wert übergeben";
            }
        }
    }
}