namespace WPFApp.Models.Dtos;

public class Rate
{
    public string Id { get; set; } = null!;
    public string Symbol { get; set; } = null!;
    public string CurrencySymbol { get; set; } = null!;
    public string RateUsd { get; set; } = null!;
    public string Type { get; set; } = null!;
}