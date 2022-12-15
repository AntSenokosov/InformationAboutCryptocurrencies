using System.IO;
using System.Threading.Tasks;
using WPFApp.Services.Interfaces;

namespace WPFApp.Services;

public class FileService : IFileService
{
    public async Task<string> ReadFile(string path)
    {
        return await File.ReadAllTextAsync(path);
    }
}