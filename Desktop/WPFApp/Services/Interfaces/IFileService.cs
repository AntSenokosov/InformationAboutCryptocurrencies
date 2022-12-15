using System.Threading.Tasks;

namespace WPFApp.Services.Interfaces;

public interface IFileService
{
    public Task<string> ReadFile(string path);
}