// See https://aka.ms/new-console-template for more information
using ISDalamudUpdater;
using XIVLauncher.Common.Dalamud;


FolderProvider fp = new FolderProvider("%APPDATA%\\XIVLauncher");

foreach (var arg in Environment.GetCommandLineArgs())
{
    if (arg.StartsWith("--roamingPath=", StringComparison.Ordinal))
    {
        fp.SetRoot(arg.Substring(14));
    }
}

DalamudInfoProxy dalamudLoadInfo = new DalamudInfoProxy();
DalamudUpdater   dalamudUpdater  = new DalamudUpdater(fp.Addons, fp.Runtime, fp.Assets, fp.Root, null, null)
{
    Overlay = dalamudLoadInfo
};

Console.WriteLine($"Using path: {fp.Root}");

dalamudUpdater.ShowOverlay();
dalamudUpdater.Run();

while (dalamudUpdater.State == DalamudUpdater.DownloadState.Unknown)
{
    Thread.Sleep(500);
}

Console.WriteLine("Dalamud update finished!");
Console.WriteLine($"Updater state: {dalamudUpdater.State}");
