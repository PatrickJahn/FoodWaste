﻿using System;
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

        [HttpGet("stores/{kind}")]
        public async Task<String> GetStoresKind(string kind)
        {
           
               return await salling.fetchAllStores(kind);
        }


           [HttpGet("offers")]
        public async Task<String> GetOffers()
        {
           
               return await salling.fetchOffers(null, "2300");
        }

               [HttpGet("offers/{id}")]
        public async Task<String> GetOfferss(string id)
        {
           
               return await salling.fetchOffers(id, null);
        }
      
      
    }
}
