using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;
using Realmdigital_Interview.Models;

namespace Realmdigital_Interview.Repositories
{
    public class Repository
    {
        public List<Product> GetProductById(string productId)
        {
            string response;
            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                response = client.UploadString("http://192.168.0.241/eanlist?type=Web", "POST", "{ \"id\": \"" + productId + "\" }");
            }
            return JsonConvert.DeserializeObject<List<Product>>(response);
        }

        public List<Product> GetProductsByName(string productName)
        {
            string response;
            using (var client = new WebClient())
            {
                client.Headers[HttpRequestHeader.ContentType] = "application/json";
                response = client.UploadString("http://192.168.0.241/eanlist?type=Web", "POST", "{ \"id\": \"" + productName + "\" }");
            }
            return JsonConvert.DeserializeObject<List<Product>>(response);
        }
    }
}