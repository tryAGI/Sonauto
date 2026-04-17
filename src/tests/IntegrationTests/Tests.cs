namespace Sonauto.IntegrationTests;

[TestClass]
public partial class Tests
{
    private static SonautoClient GetAuthenticatedClient()
    {
        var apiKey =
            Environment.GetEnvironmentVariable("SONAUTO_API_KEY") is { Length: > 0 } apiKeyValue
                ? apiKeyValue
                : throw new AssertInconclusiveException("SONAUTO_API_KEY environment variable is not found.");

        var client = new SonautoClient(apiKey);
        
        return client;
    }
}
