using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace FoodWasteHTTPCall
{
    public class Salling
    {
         private string Token = "Bearer cf09e708-cba9-4d57-9f0b-ff1102610685";
        private readonly HttpClient HttpClient;
        public Salling()
        {
        HttpClient = new HttpClient();
	
        }


        public  async Task<string> GetProductAsync(string path)
        {
            try{
            using (var request = new HttpRequestMessage(HttpMethod.Get, path))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", "cf09e708-cba9-4d57-9f0b-ff1102610685");
                var response = await HttpClient.SendAsync(request);
                var e =  await response.Content.ReadAsStringAsync();
                return e.ToString();
            }
            }catch(Exception ex){
                Console.WriteLine(ex);
                return "Error";
            }
        }
    }
}
