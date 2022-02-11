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


        public  async Task<string> fetchAllStores(string kind = null)
        {
            string url = kind == null ? "https://api.sallinggroup.com/v2/stores/" : "https://api.sallinggroup.com/v2/stores/?brand=" + kind;
            try{
            
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", TOKEN);
                    
                    HttpResponseMessage response = await HttpClient.SendAsync(request);

                    string storeData =  serializeStores(await response.Content.ReadAsStringAsync());
                    return storeData;
    
            }catch(Exception ex){
                Console.WriteLine(ex);
                    return "{\"error\": \"Could not retrive store data\"}";
            }
        }


        private string serializeStores(string json){

            FoodWaste.Store[] storeObj = JsonSerializer.Deserialize<FoodWaste.Store[]>(json)!;
            String jsonStores = JsonSerializer.Serialize(storeObj);
            return jsonStores;
        }

               private string serializeSearchItem(string json){
                    Console.WriteLine(json); 
            FoodWaste.searchItemList searchItemsObj = JsonSerializer.Deserialize<FoodWaste.searchItemList>(json)!;
            String jsonStores = JsonSerializer.Serialize(searchItemsObj);
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
            
          List<Object> objlist = JsonSerializer.Deserialize<List<Object>>(json)!;
            List<FoodWaste.foodWasteDTO>  foodWastedto = new List<FoodWaste.foodWasteDTO>();
        
          foreach(Object o in objlist){

              foodWastedto.Add( JsonSerializer.Deserialize<FoodWaste.foodWasteDTO>(o.ToString())!);

          }
            String jsonOffers = JsonSerializer.Serialize(foodWastedto);


            return jsonOffers;
        }
           private string serializeProduct(string json){

            FoodWaste.foodWasteDTO storeObj = JsonSerializer.Deserialize<FoodWaste.foodWasteDTO>(json)!;
            String jsonOffers = JsonSerializer.Serialize(storeObj);
            return jsonOffers;
        }

              public  async Task<string> fetchSearchItem(string searchedItem)
        {
            string url = "https://api.sallinggroup.com/v1-beta/product-suggestions/relevant-products?query=" + searchedItem;
            try{
            
                    HttpRequestMessage request = new HttpRequestMessage(HttpMethod.Get, url);
                    request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", TOKEN);
                    
                    HttpResponseMessage response = await HttpClient.SendAsync(request);

                    return await response.Content.ReadAsStringAsync();

            }catch(Exception ex){
                    Console.WriteLine(ex);
                    return "{\"error\": \"Could not retrive searched item data\"}";
            }
        }



    }
}
