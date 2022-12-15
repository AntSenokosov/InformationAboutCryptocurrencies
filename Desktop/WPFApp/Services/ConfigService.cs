using System.Threading.Tasks;
using WPFApp.Configurations;
using WPFApp.Services.Interfaces;

namespace WPFApp.Services;

public class ConfigService : IConfigService
{
    private const string _path = "appsettings.json";
    private readonly IJsonSerializerService _jsonSerializer;
    private readonly IFileService _fileService;
    private AppSettings? _settings;

    public ConfigService(
        IJsonSerializerService jsonSerializer,
        IFileService fileService)
    {
        _jsonSerializer = jsonSerializer;
        _fileService = fileService;
        LoadConfig().Wait();
    }

    public AppSettings? AppSettings => _settings;

    private async Task LoadConfig()
    {
        var data = await _fileService.ReadFile(_path);
        _settings = _jsonSerializer.Deserialize<AppSettings>(data);
    }
}