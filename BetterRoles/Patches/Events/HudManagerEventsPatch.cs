using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterRoles.Events
{
    [HarmonyPatch(typeof(HudManager))]
    public static class HudManagerEventsPatch
    {

        [HarmonyPatch(nameof(HudManager.Update))]
        [HarmonyPostfix]
        public static void HudManager_Update(HudManager __instance)
        {
            AmongUsEventHandler.Instance.RaiseHudUpdate(__instance);
        }
    }
}
