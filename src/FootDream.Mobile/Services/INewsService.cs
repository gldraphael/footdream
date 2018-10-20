using System.Collections.Generic;
using System.Threading.Tasks;
using FootDream.Mobile.Models;

namespace FootDream.Mobile.Services
{
	public interface INewsService
	{
		Task<IReadOnlyList<NewsArticle>> GetAsync();
	}
}
