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
    public class ApiController : ControllerBase
    {
   
        private readonly ILogger<ApiController> _logger;
        private FoodWasteHTTPCall.Salling salling = new FoodWasteHTTPCall.Salling();

        public ApiController(ILogger<ApiController> logger)
        {
            _logger = logger;
        }


       /// <summary>
       /// Returns a welcome message
       /// </summary>
       [HttpGet]
        public String GetDefault()
        {
    
            return "Welcome to foodwaste API ";
        }
      


       /// <summary>
       /// Returns all stores 
       /// </summary>
        /// <remarks>
        /// Here is a sample remarks placeholder.
        /// </remarks>
        [HttpGet("stores")]
        public async Task<String> GetTest()
        {
           
               return await salling.fetchAllStores();
        }

       /// <summary>
       /// Returns all stores by kind
       /// </summary>
        /// <param name="kind">The type of the desired store (Bilka, netto...)</param>
        [HttpGet("stores/{kind}")]
        public async Task<String> GetStoresKind(string kind)
        {
           
               return await salling.fetchAllStores(kind);
        }



       /// <summary>
       /// Returns all offers by storeid
       /// </summary>
       /// <param name="id">The ID for the store you want offers from</param>

       [HttpGet("offers/{id}")]
        public async Task<String> GetOfferss(string id)
        {
           
               return await salling.fetchOffers(id, null);
        }


       /// <summary>
       /// Returns all offers by zip code
       /// </summary>
       /// <param name="zip">The zip code for the store you want offers from</param>
        [HttpGet("offersbyzip/{zip}")]
        public async Task<String> GetOffers(string zip)
        {
           
               return await salling.fetchOffers(null, zip);
        }


        [HttpGet("search/{kind}")] 
        public async Task<String> GetSearchItem(string kind)
        {
           
               return await salling.fetchSearchItem(kind);
        }

    }
}
