using Microsoft.Extensions.DependencyInjection;
using Microsoft.AspNetCore.Hosting;
using Repository.InMemory;
using Repository.Interfaces;
using Microsoft.AspNetCore.TestHost;
using Microsoft.AspNetCore.Mvc.Testing;

namespace RestAPI.Tests
{
    public class RestAPIWebApplicationFactory : WebApplicationFactory<Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureTestServices(services =>
            {
                services.AddTransient<IPersonRepository, PersonInMemoryFakedRepository>();
            });

            base.ConfigureWebHost(builder);
        }
    }
}
