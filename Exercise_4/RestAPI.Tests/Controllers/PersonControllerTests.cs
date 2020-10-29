using Entities;
using Newtonsoft.Json;
using System.Collections.Generic;
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

        [Fact]
        public async void TestGetAll()
        {
            // Arrange
            var client = _factory.CreateClient();

            // Act
            var response = await client.GetAsync("/persons");

            // Assert
            Assert.NotNull(response);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

            var responseAsString = await response.Content.ReadAsStringAsync();
            var result = JsonConvert.DeserializeObject<List<Person>>(responseAsString);
            Assert.NotNull(result);
            Assert.True(result.Count > 0);
        }
    }
}
