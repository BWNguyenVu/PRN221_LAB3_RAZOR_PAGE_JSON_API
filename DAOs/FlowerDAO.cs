using BOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace DAOs
{
    public class FlowerDAO
    {
        private readonly HttpClient _httpClient;

        public FlowerDAO(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<Flower> GetFlowers(string searchString, string order, string sortBy, int pageNumber, int pageSize, string categoryIds)
        {
            var url = $"https://services.isolutions.top/api/v1/flowers?searchString={searchString}&order={order}&sortBy={sortBy}&pageNumber={pageNumber}&pageSize={pageSize}&categoryIds={categoryIds}";

            var response = _httpClient.GetAsync(url).Result;

            if (!response.IsSuccessStatusCode)
            {
                throw new Exception("Error fetching flower data.");
            }

            var content = response.Content.ReadAsStringAsync().Result;

            if (string.IsNullOrEmpty(content))
            {
                throw new Exception("No content returned from the API.");
            }

            var flowerData = JsonSerializer.Deserialize<Root>(content, new JsonSerializerOptions
            {
                PropertyNameCaseInsensitive = true
            });


            if (flowerData?.Content == null || flowerData.Content.Count == 0)
            {
                Console.WriteLine("No flowers found.");
                return new List<Flower>();
            }

            return flowerData.Content;
        }
    }
}
