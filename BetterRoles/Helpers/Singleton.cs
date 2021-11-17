using System;
using System.Collections.Generic;
using System.Text;

namespace BetterRoles.Extentions
{
    public class Singleton<T>
    {
        public static T _instance;

        public static T Instance
        {
            get
            {
                if (Singleton<T>._instance == null)
                {
                    Singleton<T>._instance = (T)Activator.CreateInstance(typeof(T));
                }
                return Singleton<T>._instance;
            }
        }

    }
}
