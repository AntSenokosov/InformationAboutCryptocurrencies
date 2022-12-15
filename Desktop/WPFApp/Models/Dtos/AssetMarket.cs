namespace WPFApp.Models.Dtos;

public class AssetMarket
{
    public string ExchangeId { get; set; } = null!;
    public string BaseId { get; set; } = null!;
    public string QuoteId { get; set; } = null!;
    public string BaseSymbol { get; set; } = null!;
    public string QuoteSymbol { get; set; } = null!;
    public string? VolumeUsd24Hr { get; set; }
    public string PriceUsd { get; set; } = null!;
    public string? VolumePercent { get; set; }
}