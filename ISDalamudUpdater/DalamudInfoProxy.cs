using XIVLauncher.Common.PlatformAbstractions;

namespace ISDalamudUpdater;

public class DalamudInfoProxy : IDalamudLoadingOverlay
{
    public void SetStep(IDalamudLoadingOverlay.DalamudUpdateStep step)
    {
        Console.WriteLine($"Now processing: {step.ToString()}");
    }

    public void SetVisible()
    {
        Console.WriteLine("Dalamud update started.");
    }

    public void SetInvisible()
    {
        Console.WriteLine("SetInvisible called!");
    }

    public void ReportProgress(long? size, long downloaded, double? progress)
    {
        // Don't want no spam in my console, dood!
        // Console.WriteLine($"Update progress: {progress}%");
    }
}