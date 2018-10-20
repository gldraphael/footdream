using FootDream.Mobile.ViewModels.DesignTime;
using Xamarin.Forms;

namespace FootDream.Mobile.ViewModels
{
	public static class VMFactory
	{
		public static NewsListVM NewsList => idm ? DesignTimeData.NewsList : new NewsListVM();

		/// <summary>
		/// IDM => Is Design Mode 
		/// </summary>
		private static bool idm => DesignMode.IsDesignModeEnabled;
	}
}
