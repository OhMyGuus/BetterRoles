using BepInEx.Logging;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace BetterRoles
{
    internal class Logger
    {
        private static ManualLogSource logger;
        public static void Log(string log, [CallerMemberName] string caller = "")
        {
            if (logger == null)
                return;
            var methodInfo = new StackTrace().GetFrame(1).GetMethod();
            var clasName = methodInfo.ReflectedType.Name;
            logger.LogMessage($"[{clasName}] {log}");
        }


        public static void SetLogger(ManualLogSource loggerSource)
        {
            logger = loggerSource;
        }
    }
}
