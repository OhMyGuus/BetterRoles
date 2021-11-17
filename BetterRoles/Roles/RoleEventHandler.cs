using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetterRoles.Roles
{
    internal class RoleEventHandler
    {
        private BaseRole role;

        public RoleEventHandler(BaseRole role)
        {
            this.role = role;
        }

        public void Start()
        {
            AmongUsEventHandler.Instance.InitializeEvents(this);
        }
        public void Stop()
        {
            AmongUsEventHandler.Instance.DestroyEvents(this);
        }

        public virtual void OnHudUpdate(object sender, EventArgs e)
        {
            role.OnHudUpdate((HudManager)sender);
        }

        internal void OnAbilityButtonClick(object sender, EventArgs e)
        {
            if(role.currentCooldown <= 0)
            role.OnButtonClick();
        }
    }
}
