using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using FootDream.Mobile.Models;
using Newtonsoft.Json;

namespace FootDream.Mobile.Services
{
	public class NewsService : INewsService
	{
		private readonly static HttpClient httpClient = new HttpClient();
		private const string newsEndpoint = "https://footdream.azurewebsites.net/api/news";

		public async Task<IReadOnlyList<NewsArticle>> GetAsync() 
		{
			var response = await httpClient.GetStringAsync(newsEndpoint);
			return JsonConvert.DeserializeObject<List<NewsArticle>>(response).AsReadOnly();
		}
	}
}
