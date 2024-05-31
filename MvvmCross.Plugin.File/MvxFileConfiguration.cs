namespace Cross.Plugin.File;

public class MvxFileConfiguration(string basePath)
{
    /// <summary>
    /// Gets or sets a value indicating whether the default path should be appended to the one
    /// provided by the consumer when manipulating the files. Defaults to true.
    /// </summary>
    ///
    public bool AppendDefaultPath { get; set; } = true;

    public string BasePath { get; set; } = basePath;
}