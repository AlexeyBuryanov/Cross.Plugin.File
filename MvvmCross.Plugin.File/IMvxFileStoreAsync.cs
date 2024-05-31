namespace Cross.Plugin.File;

/// <summary>
///     Warning: this interface not implemented on all platforms currently
/// </summary>
public interface IMvxFileStoreAsync
{
    Task<TryResult<string>> TryReadTextFileAsync(string path);

    Task<TryResult<string>> TryReadTextFileAsync(string path, CancellationToken cancellationToken);

    Task<TryResult<byte[]>> TryReadBinaryFileAsync(string path);

    Task<TryResult<byte[]>> TryReadBinaryFileAsync(string path, CancellationToken cancellationToken);

    Task<bool> TryReadBinaryFileAsync(string path, Func<Stream, Task<bool>> readMethod);

    Task<bool> TryReadBinaryFileAsync(string path, Func<Stream, CancellationToken, Task<bool>> readMethod, CancellationToken cancellationToken);

    Task WriteFileAsync(string path, string contents);

    Task WriteFileAsync(string path, string contents, CancellationToken cancellationToken);

    Task WriteFileAsync(string path, IEnumerable<byte> contents);

    Task WriteFileAsync(string path, IEnumerable<byte> contents, CancellationToken cancellationToken);

    Task WriteFileAsync(string path, Func<Stream, Task> writeMethod);

    Task WriteFileAsync(string path, Func<Stream, CancellationToken, Task> writeMethod, CancellationToken cancellationToken);
}