using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeHollow.FeedReader;
using CodeHollow.FeedReader.Feeds;
using FootDream.Web.Models;
using Mapster;

namespace FootDream.Web.Services
{
	public class SimpleNewsService : INewsService
	{

		const string feedUrl = "https://www.theguardian.com/football/rss";

		public async Task<IList<NewsArticle>> GetAsync()
		{
			var feed = await FeedReader.ReadAsync(feedUrl);
			switch(feed.Type)
			{
				case FeedType.MediaRss:
					{
						var feed2_0 = feed.SpecificFeed as MediaRssFeed;
						return feed2_0.Items
							          .Cast<MediaRssFeedItem>()
							          .Adapt<List<NewsArticle>>()
							          .AsReadOnly();
					}
				default:
					{
						return feed.Items
							       .Adapt<List<NewsArticle>>()
							       .AsReadOnly();
					}
			}
		}
	}
}
