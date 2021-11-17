using HarmonyLib;
using System;
using System.Collections.Generic;
using System.Text;

namespace BetterRoles.Patches.Events
{
    [HarmonyPatch(typeof(AbilityButton))]
    public static class AbilityButtonEventsPatch
    {

        [HarmonyPatch(nameof(AbilityButton.DoClick))]
        [HarmonyPostfix]
        public static void ActionButton(AbilityButton __instance)
        {
            AmongUsEventHandler.Instance.RaiseAbilityButtonClick(__instance);
        }
    }
}
