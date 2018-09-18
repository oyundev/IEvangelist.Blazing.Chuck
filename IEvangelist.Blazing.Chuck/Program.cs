using Microsoft.AspNetCore.Blazor.Hosting;

namespace IEvangelist.Blazing.Chuck
{
    public class Program
    {
        public static void Main(string[] args)
            => CreateHostBuilder(args).Build().Run();

        private static IWebAssemblyHostBuilder CreateHostBuilder(string[] args)
            => BlazorWebAssemblyHost.CreateDefaultBuilder()
                                    .UseBlazorStartup<Startup>();
    }
}