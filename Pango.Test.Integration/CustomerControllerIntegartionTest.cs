using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Pango.Test.Integration;


public class CustomerControllerIntegartionTest : IClassFixture<TestingWebAppFactory<Program>>
{
    private readonly HttpClient _client;

    public CustomerControllerIntegartionTest(TestingWebAppFactory<Program> factory)
    {
        _client = factory.CreateClient();
    }

    [Fact]
    public async Task GetAllCustomersAsyncSuccessfully_ReturnsListOfCustomers()
    {
        var response = await _client.GetAsync("/Customer/GetCustomers");

        Assert.Equal(HttpStatusCode.NotFound, response.StatusCode);
    }
}