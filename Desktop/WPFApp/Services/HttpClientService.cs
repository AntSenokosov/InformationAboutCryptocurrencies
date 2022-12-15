using System;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using WPFApp.Services.Interfaces;

namespace WPFApp.Services;

public class HttpClientService : IHttpClientService
{
    private readonly IHttpClientFactory _clientFactory;
    private readonly IJsonSerializerService _jsonSerializer;

    public HttpClientService(
        IHttpClientFactory clientFactory,
        IJsonSerializerService jsonSerializer)
    {
        _clientFactory = clientFactory;
        _jsonSerializer = jsonSerializer;
    }

    public async Task<TResponse> SendAsync<TResponse, TRequest>(string url, HttpMethod method, TRequest? content)
    {
        var client = _clientFactory.CreateClient();

        var httpMessage = new HttpRequestMessage();
        httpMessage.RequestUri = new Uri(url);
        httpMessage.Method = method;

        if (content != null)
        {
            httpMessage.Content =
                new StringContent(_jsonSerializer.Serialize(content), Encoding.UTF8, "application/json");
        }

        var result = await client.SendAsync(httpMessage);

        if (result.IsSuccessStatusCode)
        {
            var resultContent = await result.Content.ReadAsStringAsync();
            var response = _jsonSerializer.Deserialize<TResponse>(resultContent);
            return response!;
        }

        return default(TResponse)!;
    }
}