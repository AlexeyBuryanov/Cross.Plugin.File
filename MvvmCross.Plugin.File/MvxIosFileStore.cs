using MvvmCross;

namespace Cross.Plugin.File;

[Preserve(AllMembers = true)]
public class MvxIosFileStore(bool appendDefaultPath, string basePath) : MvxIoFileStoreBase(appendDefaultPath, basePath)
{
    public const string ResScheme = "res:";

    protected override string AppendPath(string path)
    {
        if (path.StartsWith(ResScheme))
        {
            return path.Substring(ResScheme.Length);
        }

        return base.AppendPath(path);
    }
}