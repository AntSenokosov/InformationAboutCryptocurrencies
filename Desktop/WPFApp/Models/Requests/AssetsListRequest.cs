namespace WPFApp.Models.Requests;

public class AssetsListRequest
{
    public string? Search { get; set; }
    public string? Ids { get; set; }
    public int Limit { get; set; }
    public int Offset { get; set; }
}