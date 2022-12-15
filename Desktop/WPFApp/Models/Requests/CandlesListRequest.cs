namespace WPFApp.Models.Requests;

public class CandlesListRequest
{
    public string Exchange { get; set; } = null!;
    public string Interval { get; set; } = null!;
    public string BaseId { get; set; } = null!;
    public string QuoteId { get; set; } = null!;
    public long? Start { get; set; }
    public long? End { get; set; }
}