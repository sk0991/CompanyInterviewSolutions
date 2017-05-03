using System;

namespace Railways.Entities
{
    public static class InstanceManager
    {
        public static T GetInstance<T>()
        {
            Type type = Type.GetType("");
            return (T)Activator.CreateInstance(type);
        }

        public const string LocationResolver = "LocationResolver";
    }
}
