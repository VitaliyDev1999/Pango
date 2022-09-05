using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Pango.Infrastructure;
using System;
using System.Linq;

namespace Pango.Test.Integration;

public class TestingWebAppFactory<TEntryPoint> : WebApplicationFactory<Program> where TEntryPoint : Program
{
    protected override void ConfigureWebHost(IWebHostBuilder builder)
    {
        builder.ConfigureServices(services =>
        {
            var descriptor = services.SingleOrDefault(
                d => d.ServiceType ==
                    typeof(DbContextOptions<PangoContext>));
            if (descriptor != null)
                services.Remove(descriptor);

            services.AddDbContext<PangoContext>(options =>
            {
                options.UseInMemoryDatabase(Guid.NewGuid().ToString());
            });
            var sp = services.BuildServiceProvider();
            using (var scope = sp.CreateScope())
            using (var appContext = scope.ServiceProvider.GetRequiredService<PangoContext>())
            {
                try
                {
                    appContext.Database.EnsureCreated();
                }
                catch (Exception)
                {
                    //Log errors
                    throw;
                }
            }
        });
    }
}