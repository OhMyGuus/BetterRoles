using System;
using System.Collections.Generic;
using System.Text;

namespace BetterRoles.Roles.CamouflagerRole
{
    internal class Camouflager : BaseRole
    {
        public override string RoleName => "Camouflager";
        public override string Description => "Can camouflage..";
        public override bool buttonEnabled => true;

        public Camouflager() : base()
        {
           
        }

        public override void OnButtonClick()
        {
            base.OnButtonClick();
            Logger.Log("OnButtonClick!");
        }

        public override void OnHudUpdate(HudManager hud)
        {
         //   Logger.Log("OnHudUpdate!");
            base.OnHudUpdate(hud);
        }


    }
}
