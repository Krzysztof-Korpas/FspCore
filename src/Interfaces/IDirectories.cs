namespace FspCore.Interfaces
{
    public interface IDirectories
    {
        public Task<bool> CreateDirectoryAsync(string path);
        public Task<List<string>> GetSubDirectoriesAsync(string path);
        public Task<bool> DeleteDirectoryAsync(string path);

        public Task<List<string>> GetDirectoryContentAsync(string path);

    }
}
