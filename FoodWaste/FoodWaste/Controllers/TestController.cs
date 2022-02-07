using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace FoodWaste.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestController : ControllerBase
    {
   
        private readonly ILogger<TestController> _logger;

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

       

        [HttpGet]
        public String GetTest()
        {
            var salling = new FoodWasteHTTPCall.Salling();
            var e = salling.GetProductAsync("https://api.sallinggroup.com/v2/stores/");
      
            // Serialize
            return "Welcome to foodwaste API " + e;
        }
      
    }
}
