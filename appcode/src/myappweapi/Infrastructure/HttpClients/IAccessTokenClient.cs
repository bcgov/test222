namespace myappwebapi.Infrastructure.HttpClients;

using IdentityModel.Client;

public interface IAccessTokenClient
{
    Task<string> GetAccessTokenAsync(ClientCredentialsTokenRequest request);
}
