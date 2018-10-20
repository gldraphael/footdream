using System.Collections.ObjectModel;
using FootDream.Mobile.Models;

namespace FootDream.Mobile.ViewModels.DesignTime
{
	public partial class DesignTimeData
	{
		private static NewsListVM newsList;
		public static NewsListVM NewsList => newsList ?? (newsList = data);

		private static NewsListVM data => new NewsListVM
		{
			News = new ObservableCollection<NewsArticle>
			{
				new NewsArticle { Title = "Hey there Delilah", Description = "What's it like in NY city?" },
				new NewsArticle { Title = "Hey there Delilah", Description = "What's it like in NY city?" },
				new NewsArticle { Title = "Hey there Delilah", Description = "What's it like in NY city?" },
				new NewsArticle { Title = "Hey there Delilah", Description = "What's it like in NY city?" },
			}
		};
	}
}
