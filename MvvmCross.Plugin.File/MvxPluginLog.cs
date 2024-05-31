using Microsoft.Extensions.Logging;
using MvvmCross.Logging;

namespace Cross.Plugin.File;

internal static class MvxPluginLog
{
    internal static ILogger Instance { get; } = MvxLogHost.GetLog("MvxPlugin.FieldBinding");
}