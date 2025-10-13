using UavRouteUI.Models;
using System.Text.Json;
using Microsoft.Extensions.Options;

namespace UavRouteUI.Services
{
   public class UavData
    {
        private string ApiUrl;
        private HttpClient HttpClient;
        private JsonSerializerOptions JsonOptions;

        public UavData()
        {
            ApiUrl = "http://localhost:5188/api/uav";
            HttpClient = new HttpClient();//deals with the http requests 
            JsonOptions =  new JsonSerializerOptions
                    {
                    PropertyNameCaseInsensitive = true
                    };
        }
        public List<Uav> GetUavs()
        {
            //go to api and get uav data from database 
            var JsonApiData = HttpClient.GetAsync(ApiUrl).Result.Content.ReadAsStringAsync().Result;//Json  
            var ApiData = JsonSerializer.Deserialize<List<Uav>>(JsonApiData, JsonOptions);//turns Json text into uav objects
            return ApiData ?? new List<Uav>(); // ?? is like an if ApiData is null then return an empty list of Uav.

        }

    }
}