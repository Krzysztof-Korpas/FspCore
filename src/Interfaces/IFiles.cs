namespace FspCore.Interfaces
{
    public interface IFiles
    {
        public Task<bool> CreateFileAsync(string path);
        public Task<bool> DeleteFileAsync(string path);
        public Task<bool> MoveFileAsync(string source, string destination);

        public Task<byte[]> GetFileAsync(string path);

    }
}
