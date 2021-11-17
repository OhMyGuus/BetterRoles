using BepInEx;
using BepInEx.IL2CPP;
using BetterRoles.Roles;
using HarmonyLib;

namespace BetterRoles
{
    [BepInPlugin(Id, "Better Roles", Version)]
    public class BetterRoles : BasePlugin
    {
        const string Id = "nl.bettercrewlink.betterroles";
        private const string Version = "0.0.1";

        static readonly Harmony Harmony = new Harmony(Id);

        public override void Load()
        {
            Logger.SetLogger(Log);
            Logger.Log("Initializing BetterRoles");

            Harmony.PatchAll();
            Initialize();
        }

        public void Initialize()
        {
            RolesManager.Instance.InitializeRoles();
        }

    }
}

