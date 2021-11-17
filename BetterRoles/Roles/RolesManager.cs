using BetterRoles.Extentions;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BetterRoles.Roles
{
    public class RolesManager : Singleton<RolesManager>
    {
        public List<BaseRole> Roles { get; set; } = new List<BaseRole>();

        public void InitializeRoles()
        {
            var basetype = typeof(BaseRole);
            var types = AppDomain.CurrentDomain.GetAssemblies()
                .SelectMany(a => a.GetTypes())
                .Where(t => t.IsClass && !t.IsAbstract && t.IsSubclassOf(basetype));
            foreach (var t in types)
            {
                BaseRole role = (BaseRole)Activator.CreateInstance(t);
                role.InitializeRole();
                Roles.Add(role);
                Logger.Log($"got role: {role.RoleName}");
            }
        }
    }
}
