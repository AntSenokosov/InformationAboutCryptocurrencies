namespace WPFApp.Services.Interfaces;

public interface IJsonSerializerService
{
    public string Serialize<T>(T data);

    public T Deserialize<T>(string value);
}