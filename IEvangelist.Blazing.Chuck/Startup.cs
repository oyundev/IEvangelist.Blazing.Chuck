using Microsoft.AspNetCore.Blazor.Builder;
using Microsoft.Extensions.DependencyInjection;

namespace IEvangelist.Blazing.Chuck
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
            => services.AddCors(
                options =>
                    options.AddDefaultPolicy(
                        builder =>
                            builder.AllowAnyOrigin()
                                   .AllowAnyMethod()
                                   .AllowAnyHeader()
                                   .AllowCredentials()));

        public void Configure(IBlazorApplicationBuilder app) 
            => app.AddComponent<App>("app");
    }
}