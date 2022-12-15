namespace WPFApp.Models.Dtos;

public class Market
{
    public string ExchangeId { get; set; } = null!;
    public string Rank { get; set; } = null!;
    public string BaseSymbol { get; set; } = null!;
    public string BaseId { get; set; } = null!;
    public string QuoteSymbol { get; set; } = null!;
    public string QuoteId { get; set; } = null!;
    public string PriceQuote { get; set; } = null!;
    public string PriceUsd { get; set; } = null!;
    public string? VolumeUsd24Hr { get; set; }
    public string? PercentExchangeVolume { get; set; }
    public string? TradesCount24Hr { get; set; }
    public long Updated { get; set; }
}