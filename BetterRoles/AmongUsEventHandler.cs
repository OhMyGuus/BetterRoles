using BetterRoles.Extentions;
using BetterRoles.Roles;
using System;

namespace BetterRoles
{
    internal class AmongUsEventHandler : Singleton<AmongUsEventHandler>
    {
        public event EventHandler OnHudUpdate;
        public event EventHandler OnAbilityButtonClick;


        public void RaiseHudUpdate(HudManager hud)
        {
            OnHudUpdate?.Invoke(hud, null);
        }
        public void RaiseAbilityButtonClick(AbilityButton instance)
        {
            OnAbilityButtonClick?.Invoke(instance, null);
        }
        public void InitializeEvents(RoleEventHandler roleEventHandler)
        {
            OnHudUpdate += roleEventHandler.OnHudUpdate;
            OnAbilityButtonClick += roleEventHandler.OnAbilityButtonClick;
        }

        public void DestroyEvents(RoleEventHandler baseRole)
        {
            OnHudUpdate -= baseRole.OnHudUpdate;
        }
    }
}
