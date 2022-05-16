using Uppertools.DesafioDotNet.Debugging;

namespace Uppertools.DesafioDotNet
{
    public class DesafioDotNetConsts
    {
        public const string LocalizationSourceName = "DesafioDotNet";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = false;

        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "e00d46374a5243bea6725f46795e78e4";
    }
}
