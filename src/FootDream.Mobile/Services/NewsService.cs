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

		public async Task<IReadOnlyList<NewsArticle>> GetAsync() 
		{
			var response = await httpClient.GetStringAsync("https://localhost:5001/api/news");
			return JsonConvert.DeserializeObject<List<NewsArticle>>(response).AsReadOnly();
		}
	}
}
