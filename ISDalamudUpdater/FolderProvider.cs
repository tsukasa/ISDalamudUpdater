namespace ISDalamudUpdater;

public class FolderProvider
{
    public DirectoryInfo Root { get; set; } = null!;
    public DirectoryInfo Addons => new DirectoryInfo(Path.Combine(Root.FullName, "addon"));
    public DirectoryInfo Assets => new DirectoryInfo(Path.Combine(Root.FullName, "dalamudAssets"));
    public DirectoryInfo Runtime => new DirectoryInfo(Path.Combine(Root.FullName, "runtime"));

    public void SetRoot(string rootPath)
    {
        Root = new DirectoryInfo(Environment.ExpandEnvironmentVariables(rootPath));
    }
    public FolderProvider(string rootPath)
    {
        SetRoot(rootPath);
    }
}