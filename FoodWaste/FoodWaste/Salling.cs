using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace FoodWasteHTTPCall
{
    public class Salling
    {
        private readonly string TOKEN = "cf09e708-cba9-4d57-9f0b-ff1102610685";
        private readonly HttpClient HttpClient;
        public Salling()
        {
        HttpClient = new HttpClient();
	
        }


        public  async Task<string> fetchAllStores()
        {
            string url = "https://api.sallinggroup.com/v2/stores/";
            try{
            
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", TOKEN);
                    
                    HttpResponseMessage response = await HttpClient.SendAsync(request);

                    string storeData =  serializeStores(await response.Content.ReadAsStringAsync());
                    return storeData;
    
            }catch(Exception ex){
                    return "{\"error\": \"Could not retrive store data\"}";
            }
        }

        private string serializeStores(string json){

            FoodWaste.Store[] storeObj = JsonSerializer.Deserialize<FoodWaste.Store[]>(json)!;
            String jsonStores = JsonSerializer.Serialize(storeObj);
            return jsonStores;
        }


          public  async Task<string> fetchOffers(String storeId = null, String zip = null)
        {

             string url = "";
             Boolean singleStore = false;
            if (zip != null){
                url = "https://api.sallinggroup.com/v1/food-waste/?zip=" + zip;
           
            } 
            else if (storeId != null){
                url = "https://api.sallinggroup.com/v1/food-waste/" + storeId;
                singleStore = true;
            } else return null;


            try{
            
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", TOKEN);
                    
                    HttpResponseMessage response = await HttpClient.SendAsync(request);

                    string productData = singleStore ? serializeProduct(await response.Content.ReadAsStringAsync()) :
                                                       serializeProducts(await response.Content.ReadAsStringAsync());
                    return productData;
    
            }catch(Exception ex){
                    Console.WriteLine(ex);
                    return "{\"error\": \"Could not retrive offers data\"}";
            }
        }

           private string serializeProducts(string json){
            
           FoodWaste.Clearances objlist = JsonSerializer.Deserialize<FoodWaste.Clearances >(json)!;


           Console.WriteLine(objlist);
            String jsonOffers = JsonSerializer.Serialize(objlist);


            return jsonOffers;
        }
           private string serializeProduct(string json){

            FoodWaste.Clearances storeObj = JsonSerializer.Deserialize<FoodWaste.Clearances>(json)!;
            String jsonOffers = JsonSerializer.Serialize(storeObj);
            return jsonOffers;
        }




    }
}
