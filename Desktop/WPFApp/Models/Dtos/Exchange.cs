namespace WPFApp.Models.Dtos;

public class Exchange
{
    public string Id { get; set; } = null!;
    public string Name { get; set; } = null!;
    public string Rank { get; set; } = null!;
    public string PercentTotalVolume { get; set; } = null!;
    public string VolumeUsd { get; set; } = null!;
    public string TradingPairs { get; set; } = null!;
    public bool Socket { get; set; }
    public string ExchangeUrl { get; set; } = null!;
    public long Updated { get; set; }
}