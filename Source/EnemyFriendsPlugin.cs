using UnityEngine;
using BepInEx;
using System;

namespace Nyxpiri.ULTRAKILL.EnemyFriends
{
    public static class Cheats
    {
        public const string GiveEnemiesFriends = "nyxpiri.give-enemies-friends";
    }

    [BepInPlugin("com.nyxpiri.bepinex.plugins.ultrakill.enemy-friends", "Enemy Friends", "0.0.0.1")]
    [BepInProcess("ULTRAKILL.exe")]
    public class EnemyFriends : BaseUnityPlugin
    {
        protected void Awake()
        {
            Log.Initialize(Logger);
            Options.Config = Config;
            Options.Initialize();
            EnemyFriendIdentifier.Initialize();
            NyxLib.Cheats.ReadyForCheatRegistration += RegisterCheats;
        }

        private void RegisterCheats(CheatsManager cheatsManager)
        {
            cheatsManager.RegisterCheat(new ToggleCheat(
                "Give Enemies Friend(s)! c:", 
                Cheats.GiveEnemiesFriends,
                onDisable: (cheat) =>
                {
                },
                onEnable: (cheat, manager) =>
                {
                }
            ), "misc");
        }
        
        protected void OnApplicationFocus(bool hasFocus)
        {
            if (hasFocus)
            {
                Config.Reload();
            }
        }

        protected void Start()
        {
        }

        protected void Update()
        {

        }

        protected void LateUpdate()
        {

        }
    }
}
