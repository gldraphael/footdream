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
				new NewsArticle 
				{ 
					Title = "Internazionale v Milan: Serie A – live!", 
					Link = "https://www.theguardian.com/football/live/2018/oct/21/internazionale-v-milan-serie-a-live",
					Description = "Inter boss Luciano Spalletti reckons fans of the club are more likely to forget their partner’s birthday than when they play AC Milan. Luckily, for me, Mrs Live Blogger always gives me a reminder that I need to buy her something to make up annually for me spending Sunday nights writing about football matches in foreign countries.",
					ImageUrl = "https://i.guim.co.uk/img/media/a0d7e92d4b18c29fbd849ba6e858799c6ed5398f/0_148_3500_2100/master/3500.jpg?width=460&quality=85&auto=format&fit=max&s=7e2356dde705e3acfc7554a979be2349"
				},
				new NewsArticle 
				{ 
					Title = "Glazers do not intend to sell Manchester United amid reports of Saudi interest", 
					Link = "https://www.theguardian.com/football/2018/oct/21/glazer-family-have-no-immediate-intention-to-sell-manchester-united",
					Description = "What's Crown Prince of Saudi Arabia linked with £4bn takeover bid like in NY city?",
					ImageUrl = "https://i.guim.co.uk/img/media/481de4339f01e5470861ee1aa0ae14beb8aaea93/0_15_3500_2100/master/3500.jpg?width=460&quality=85&auto=format&fit=max&s=8023f992ad5a2f3a9f36d2e3677d9583"
				},
				new NewsArticle
				{
					Title = "Dominic Calvert-Lewin sparks Everton’s late demolition of Crystal Palace",
					Link = "https://www.theguardian.com/football/2018/oct/21/everton-crystal-palace-premier-league-match-report",
					Description = "Everton left it late, very late, to record their third consecutive Premier League win under Marco Silva and leave Crystal Palace with an all-too-familiar sense of regret. The substitutes Dominic Calvert-Lewin and Cenk Tosun struck twice in the final three minutes at Goodison Park to punish Roy Hodgson’s profligate side.",
					ImageUrl = "https://i.guim.co.uk/img/media/fd0b1f7f93ccf84dbd2a6dfb4c2c0ba62fa3ceeb/66_102_3434_2060/master/3434.jpg?width=460&quality=85&auto=format&fit=max&s=b12238685432a4e016318b489d5b369e"
				},
				new NewsArticle
				{
					Title = "Rochdale’s saviour Joe Thompson on surviving cancer: ‘Karma comes around’",
					Link = "https://www.theguardian.com/football/2018/oct/21/rochdale-joe-thompson-cancer",
					Description = "WThe winger’s goal that kept Rochdale in League One capped an extraordinary comeback from a recurrence of Hodgkin lymphoma",
					ImageUrl = "https://i.guim.co.uk/img/media/7f5e872b8fca862b0fac556736c0d66f01e2241a/0_0_6585_3951/master/6585.jpg?width=460&quality=85&auto=format&fit=max&s=62b457731d53db47e3966a5d488edcfb"
				},
			}
		};
	}
}
