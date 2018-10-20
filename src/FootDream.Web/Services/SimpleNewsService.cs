using System.Collections.Generic;
using System.Threading.Tasks;
using CodeHollow.FeedReader;
using FootDream.Web.Models;
using Mapster;

namespace FootDream.Web.Services
{
	public class SimpleNewsService : INewsService
	{

		const string feedUrl = "http://www.goal.com/en-us/feeds/news?fmt=rss";

		public async Task<IList<NewsArticle>> GetAsync()
		{
			var feed = await FeedReader.ReadAsync(feedUrl);
			return feed.Items.Adapt<List<NewsArticle>>().AsReadOnly();
		}
	}
}
