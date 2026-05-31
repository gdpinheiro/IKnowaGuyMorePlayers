using BepInEx;
using BepInEx.Configuration;
using BepInEx.Unity.IL2CPP;
using HarmonyLib;

namespace IKnowaGuyMorePlayers
{
    [BepInPlugin("com.github.IKnowaGuyMorePlayers", "IKnowaGuyMorePlayers", "1.0.0")]
    public class Plugin : BasePlugin
    {
        public static ConfigEntry<int> MaxPlayers { get; private set; }

        public override void Load()
        {
            MaxPlayers = Config.Bind(
                "General",
                "MaxPlayers",
                8,
                "The maximum number of players allowed in a lobby. Only applies when you are the host. Vanilla default is 4."
            );

            Harmony harmony = new Harmony("com.github.IKnowaGuyMorePlayers");
            harmony.PatchAll();

            Log.LogInfo("IKnowaGuyMorePlayers loaded!");
        }
    }
}