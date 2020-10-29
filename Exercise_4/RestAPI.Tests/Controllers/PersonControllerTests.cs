using System.Net;
using Xunit;

namespace RestAPI.Tests.Controllers
{
    public class PersonControllerTests : IClassFixture<RestAPIWebApplicationFactory>
    {
        private RestAPIWebApplicationFactory _factory;

        public PersonControllerTests(RestAPIWebApplicationFactory factory)
        {
            _factory = factory;
        }

        [Theory]
        [InlineData("/persons")]
        [InlineData("/persons/5")]
        public async void TestGetAll(string url)
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync(url);

            // Assert
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
    }
}
