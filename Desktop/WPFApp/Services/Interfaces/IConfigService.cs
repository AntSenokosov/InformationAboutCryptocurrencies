using WPFApp.Configurations;

namespace WPFApp.Services.Interfaces;

public interface IConfigService
{
    public AppSettings? AppSettings { get; }
}