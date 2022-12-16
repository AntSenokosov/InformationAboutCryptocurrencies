using System.Collections.Generic;
using System.Threading.Tasks;
using WPFApp.Models.Dtos;
using WPFApp.Models.Requests;

namespace WPFApp.Services.Interfaces;

public interface ICatalogService
{
    public Task<IEnumerable<Asset>> GetAssetsAsync();
    public Task<Asset> GetAssetAsync(string id);
    public Task<IEnumerable<Asset>> SearchAssetAsync(AssetsListRequest request);
    public Task<IEnumerable<Asset>> ListTopAssetAsync(AssetsListRequest request);
}