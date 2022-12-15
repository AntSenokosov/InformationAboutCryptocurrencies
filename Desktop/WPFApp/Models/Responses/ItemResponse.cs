namespace WPFApp.Models.Responses;

public class ItemResponse<T>
{
    public T Data { get; set; } = default(T)!;
    public long Timestamp { get; set; }
}