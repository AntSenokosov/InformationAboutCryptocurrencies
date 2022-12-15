using Newtonsoft.Json;
using WPFApp.Services.Interfaces;

namespace WPFApp.Services;

public class JsonSerializerService : IJsonSerializerService
{
    public string Serialize<T>(T data)
    {
        return JsonConvert.SerializeObject(data);
    }

    public T Deserialize<T>(string value)
    {
        return JsonConvert.DeserializeObject<T>(value)!;
    }
}