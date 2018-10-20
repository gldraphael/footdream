using System.Threading.Tasks;
using FootDream.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace FootDream.Web.Controllers
{
	[ApiController, Route("api/[controller]")]
	public class NewsController : Controller
	{
		[HttpGet("")]
		[ResponseCache(Duration = 1_800)] // 30 minutes
		public async Task<IActionResult> GetNews([FromServices]INewsService news) => 
			Ok(await news.GetAsync());
	}
}
