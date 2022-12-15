namespace WPFApp.Models.Requests;

public class GetAssetIdMarketsRequest
{
    public string Id { get; set; } = null!;
    public int? Limit { get; set; }
    public int? Offset { get; set; }
}