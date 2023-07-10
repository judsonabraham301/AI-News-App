using AINewsApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace AINewsApp.Services
{
    public class AINewsService
    {
        private HttpClient httpClient;
        private List<AINews> news = new();
        public AINewsService()
        {
            httpClient = new HttpClient();
        }
        
        public async Task<List<AINews>> GetNewsAsync()
        {
            var url = "https://mocki.io/v1/7aae1655-d701-4fb2-a8e3-e367a36f6135";
            var response = await httpClient.GetAsync(url);
            if (response.IsSuccessStatusCode)
            {
                news = await response.Content.ReadFromJsonAsync<List<AINews>>();
            }
            return news;
        }
    }
}
