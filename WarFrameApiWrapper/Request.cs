using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;

namespace WarFrameApiWrapper
{
    public class Request
    {
        HttpClient client;
        public Request()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri("https://api.warframestat.us");
        }

        /// <summary>
        /// makes a get request using the request body porovided
        /// </summary>
        /// <param name="requestObj"></param>
        /// <param name="requestBody"></param>
        /// <returns>fills the given object with data pulled from warframe's API</returns>
        public async Task RequestItem(object requestObj, string requestBody)
        {
            var response =  await client.GetAsync(requestBody);

            string json = response.Content.ReadAsStringAsync().Result;

            var settings = new JsonSerializerSettings()
            {
                NullValueHandling = NullValueHandling.Ignore
            };

            if (json != null && json != "" && json != "[ ]")
            {
                JsonConvert.PopulateObject(json, requestObj, settings);
            }
        } 
    }
}
