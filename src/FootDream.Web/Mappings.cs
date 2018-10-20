using System.Linq;
using CodeHollow.FeedReader.Feeds;
using FootDream.Web.Models;
using Mapster;

namespace FootDream.Web
{
	public static class Mappings
	{
		public static void Register()
		{
			TypeAdapterConfig<MediaRssFeedItem, NewsArticle>
				.NewConfig()
				.Map(dest => dest.ImageUrl, src => getMediaUrl(src));
		}

		private static string getMediaUrl(MediaRssFeedItem item)
		{
			return item.Media?.Aggregate((max, m) => max.Width > m.Width ? max : m)?.Url;
		}
	}
}
