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
