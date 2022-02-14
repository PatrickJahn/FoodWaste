using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;




namespace FoodWaste{


class Serializers {
    
        public string serializeStores(string json)
        {
            FoodWaste.Store[] storeObj = JsonSerializer.Deserialize<FoodWaste.Store[]>(json)!;
            return JsonSerializer.Serialize(storeObj);
        }

        public string serializeSearchItem(string json)
        {
            FoodWaste.searchItemList searchItemsObj = JsonSerializer.Deserialize<FoodWaste.searchItemList>(json)!;
            return JsonSerializer.Serialize(searchItemsObj);
        }



        public string serializeProducts(string json)
        {
            List<Object> objlist = JsonSerializer.Deserialize<List<Object>>(json)!;
            List<FoodWaste.foodWasteDTO>  foodWastedto = new List<FoodWaste.foodWasteDTO>();
        
            foreach(Object o in objlist)
            {
                foodWastedto.Add( JsonSerializer.Deserialize<FoodWaste.foodWasteDTO>(o.ToString())!);
            }

            return JsonSerializer.Serialize(foodWastedto);

            
        }

        public string serializeProduct(string json)
        {
            FoodWaste.foodWasteDTO storeObj = JsonSerializer.Deserialize<FoodWaste.foodWasteDTO>(json)!;
            return JsonSerializer.Serialize(storeObj);
        }

    }
}