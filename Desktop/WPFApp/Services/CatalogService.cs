using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using WPFApp.Models.Dtos;
using WPFApp.Models.Requests;
using WPFApp.Models.Responses;
using WPFApp.Services.Interfaces;

namespace WPFApp.Services;

public class CatalogService : ICatalogService
{
    private readonly IHttpClientService _clientService;
    private readonly IConfigService _config;

    public CatalogService(
        IHttpClientService clientService,
        IConfigService config)
    {
        _clientService = clientService;
        _config = config;
    }

    public async Task<IEnumerable<Asset>> GetAssetsAsync()
    {
        var response = await _clientService.SendAsync<ItemsListResponse<Asset>, object>(
            $"{_config.AppSettings!.CoinCap}/assets",
            HttpMethod.Get,
            null);

        var result = response.Data;

        return result;
    }

    public async Task<Asset> GetAssetAsync(string id)
    {
        var response = await _clientService.SendAsync<ItemResponse<Asset>, object>(
            $"{_config.AppSettings!.CoinCap}/assets/{id}",
            HttpMethod.Get,
            new GetIdRequest()
            {
                Id = id
            });

        var result = response.Data;

        return result;
    }

    public async Task<IEnumerable<Asset>> SearchAssetAsync(AssetsListRequest request)
    {
        var response = await _clientService.SendAsync<ItemsListResponse<Asset>, object>(
            $"{_config.AppSettings!.CoinCap}/assets?search={request.Search}",
            HttpMethod.Get,
            null);

        var result = response.Data;

        return result;
    }

    public async Task<IEnumerable<Asset>> ListTopAssetAsync(AssetsListRequest request)
    {
        var response = await _clientService.SendAsync<ItemsListResponse<Asset>, object>(
            $"{_config.AppSettings!.CoinCap}/assets?limit={request.Limit}",
            HttpMethod.Get,
            null);

        var result = response.Data;

        return result;
    }
}