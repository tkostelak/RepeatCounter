using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace WordCounterApp
{
  public class Startup
  {
    public Startup(IHostingEnvironment env)
    {
      var builder = new ConfigurationBuilder()
        .SetBasePath(env.ContentRootPath)
        .AddEnvironmentVariables();
      Configuration = builder.Build();
    }

  public IConfigurationRoot Configuration { get;}

  public void ConfigureServices(IServiceCollection services)
  {
    services.AddMvc();
  }

  public void Configure(IApplicationBuilder app)
  {
    app.UseStaticFiles();
    app.UseDeveloperExceptionPage();
    app.UseMvc(routes =>
    {
      routes.MapRoute(
        name: "default",
        template: "{controller=Home}/{action=Index}/{id?}");
      });
      app.Run(async (context) =>
      {
        await context.Response.WriteAsync("Sorry, that path did not seem to work.");
      });
    }
  }
}
