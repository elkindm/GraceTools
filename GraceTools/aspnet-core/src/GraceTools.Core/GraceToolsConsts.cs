using GraceTools.Debugging;

namespace GraceTools
{
    public class GraceToolsConsts
    {
        public const string LocalizationSourceName = "GraceTools";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "23506535c71747599fdace541642efb8";
    }
}
