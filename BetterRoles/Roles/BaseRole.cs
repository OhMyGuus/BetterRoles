using UnityEngine;

namespace BetterRoles.Roles
{
    public abstract class BaseRole
    {
        public ActionButton AbilityButton => DestroyableSingleton<HudManager>.Instance.AbilityButton;

        public virtual UnityEngine.Sprite ButtonSprite { get; }
        public virtual bool buttonEnabled { get; set; }
        public virtual string RoleName => "Unkown";
        public virtual string Description => "Unkown";
        public virtual int Cooldown { get; set; } //TODO: move to settings or smthg..
        public virtual float ButtonCoolDown => 30;

        private RoleEventHandler roleEventHandler { get; set; }
        public float currentCooldown { get; set; } = 0;

        public BaseRole()
        {
            roleEventHandler = new RoleEventHandler(this);
        }

        public virtual void InitializeRole()
        {
            roleEventHandler.Start();
        }

        public virtual void OnStart()
        {
        }


        public virtual void OnHudUpdate(HudManager hud)
        {
            if (AbilityButton != null && ButtonSprite != null && AbilityButton.graphic.sprite != ButtonSprite)
            {
                AbilityButton.graphic.sprite = ButtonSprite;
            }
            if (AbilityButton != null && buttonEnabled)
            {
                AbilityButton.ToggleVisible(true);
                if (currentCooldown > 0)
                    currentCooldown -= Time.deltaTime;
                AbilityButton.SetCoolDown(currentCooldown, ButtonCoolDown);
            }
        }

        public void SetButton()
        {
        }

        public virtual void OnButtonClick()
        {
            currentCooldown = ButtonCoolDown;

        }

        public void RegisterRole()
        {

        }


        public virtual bool IsRole()
        {
            return true;
        }
    }
}
