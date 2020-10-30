using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.AspNetCore.TestHost;
using Microsoft.Extensions.DependencyInjection;
using Repository.Interfaces;
using RestAPI.Tests.Mocks;

namespace RestAPI.Tests
{
    public class RestAPIWebApplicationFactory : WebApplicationFactory<Startup>
    {
        protected override void ConfigureWebHost(IWebHostBuilder builder)
        {
            builder.ConfigureTestServices(services =>
            {
                services.AddTransient<IPersonRepository, MockPersonInMemoryRepository>();
            });

            base.ConfigureWebHost(builder);
        }
    }
}
