using FootDream.Mobile.ViewModels;
using Xamarin.Forms;

namespace FootDream.Mobile.Views
{
	public partial class NewsPage : ContentPage
	{
		private readonly NewsListVM vm;
		public NewsPage()
		{
			InitializeComponent();
			BindingContext = vm = VMFactory.NewsList;
		}

		protected override void OnAppearing()
		{
			base.OnAppearing();

			if (vm.News.Count is 0) vm.LoadNewsCommand.Execute(null);
		}
	}
}
