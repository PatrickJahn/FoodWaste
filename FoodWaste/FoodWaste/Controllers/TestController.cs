using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Cors;



namespace FoodWaste.Controllers
{

    [ApiController]
    [Route("api/")]
    public class TestController : ControllerBase
    {
   
        private readonly ILogger<TestController> _logger;
        private FoodWasteHTTPCall.Salling salling = new FoodWasteHTTPCall.Salling();

        public TestController(ILogger<TestController> logger)
        {
            _logger = logger;
        }

         [HttpGet]
        public String GetDefault()
        {
    

            return "Welcome to foodwaste API ";
        }
      

        [HttpGet("stores")]
        public async Task<String> GetTest()
        {
           
               return await salling.fetchAllStores();
        }


           [HttpGet("offers")]
        public async Task<String> GetOffers()
        {
           
               return await salling.fetchOffers(null, "2300");
        }

               [HttpGet("offerss")]
        public async Task<String> GetOfferss()
        {
           
               return await salling.fetchOffers("efba0457-090e-4132-81ba-c72b4c8e7fee", null);
        }
      
      
    }
}
