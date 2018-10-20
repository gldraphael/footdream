using System.Collections.Generic;
using System.Threading.Tasks;
using FootDream.Web.Models;

namespace FootDream.Web.Services
{
	public interface INewsService
	{
		Task<IList<NewsArticle>> GetAsync();
	}
}
