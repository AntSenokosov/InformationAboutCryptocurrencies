using System.Net.Http;
using System.Threading.Tasks;

namespace WPFApp.Services.Interfaces;

public interface IHttpClientService
{
    public Task<TResponse> SendAsync<TResponse, TRequest>(string url, HttpMethod method, TRequest? content);
}