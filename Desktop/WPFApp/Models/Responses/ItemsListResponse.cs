using System.Collections.Generic;

namespace WPFApp.Models.Responses;

public class ItemsListResponse<T>
{
    public IEnumerable<T> Data { get; set; } = new List<T>();
    public long Timestamp { get; set; }
}