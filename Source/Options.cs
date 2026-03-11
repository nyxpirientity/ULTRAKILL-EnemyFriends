using System.Collections.Generic;
using BepInEx.Configuration;

namespace Nyxpiri.ULTRAKILL.EnemyFriends
{
    public static class Options
    {
        public static ConfigEntry<int> NumFriendsToSpawn = null;
        
        public static void Initialize()
        {
            NumFriendsToSpawn = Config.Bind($"", "NumFriendsToSpawn", 1);
        }
        
        internal static ConfigFile Config = null;
    }
}
