using Entities;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestAPI.Controllers;
using RestAPI.Tests.Mocks;
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
        public void TestGetAllController()
        {
            // Arrange
            var repository = new MockPersonInMemoryRepository();
            var controller = new PersonController(repository);

            // Act
            var response = controller.GetAll() as OkObjectResult;

            // Assert
            Assert.NotNull(response);
            Assert.NotNull(response.Value);
            Assert.Equal((int)HttpStatusCode.OK, response.StatusCode);
            Assert.True(response.Value is List<Person>);
        }

        [Fact]
        public async void TestGetAllFactory()
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
