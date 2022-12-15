namespace WPFApp.Models.Requests;

public class GetAssetIdHistoryRequest
{
    public string Id { get; set; } = null!;
    public string Interval { get; set; } = null!;
    public long? Start { get; set; }
    public long? End { get; set; }
}