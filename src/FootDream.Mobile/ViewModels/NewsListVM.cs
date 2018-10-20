using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;
using FootDream.Mobile.Models;
using FootDream.Mobile.Services;
using Xamarin.Forms;
using Xamarin.Forms.Internals;

namespace FootDream.Mobile.ViewModels
{
	public class NewsListVM : BaseViewModel
	{
		public ObservableCollection<NewsArticle> News { get; }
		public Command LoadNewsCommand { get; }

		public NewsListVM()
		{
			Title = "News";
			News = new ObservableCollection<NewsArticle>();
			LoadNewsCommand = new Command(async () => await ExecuteLoadNewsCommand());
		}

		async Task ExecuteLoadNewsCommand()
		{
			if (IsBusy) return;

			IsBusy = true;

			try
			{
				News.Clear();
				var newsItems = await new NewsService().GetAsync();
				newsItems.ForEach(n => News.Add(n));
			}
			catch (Exception ex)
			{
				Debug.WriteLine(ex);
			}
			finally
			{
				IsBusy = false;
			}
		}
	}
}
