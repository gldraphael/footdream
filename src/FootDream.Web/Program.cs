using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace FootDream.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
			Mappings.Register();
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
