using MVP.Models;
using MVP.Services.API.Product.Interface;
using Newtonsoft.Json;

namespace MVP.Services.API.Product
{
    public class ProductAPIService : IProductAPIService
    {
        private HttpClient _httpClient;
        private readonly string url = "https://localhost:7262/api/";
        public ProductAPIService()
        {
            _httpClient = new HttpClient();
        }
        public async Task<List<ProductViewModel>> GetProduts()
        {
            var products = new List<ProductViewModel>();
            using(_httpClient = new HttpClient() { BaseAddress = new Uri(url) })
            {
               using(var response = _httpClient.GetAsync("Product").Result)
                {
                    string apiResponse = await response.Content.ReadAsStringAsync();
                    products = JsonConvert.DeserializeObject<List<ProductViewModel>>(apiResponse);
                }
            }
            return products;
        }
    }
}
