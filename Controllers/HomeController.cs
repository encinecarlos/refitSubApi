using System;
using Microsoft.AspNetCore.Mvc;

namespace refitSubApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        public ActionResult SayHello()
        {
            var message = $"Hello, the current date and time is: {DateTime.Now.ToString()}";

            return Ok(message);
        }
    }
}