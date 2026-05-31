using HarmonyLib;
using Network;
using Steamworks;

namespace IKnowaGuyMorePlayers.HarmonyPatches
{
    [HarmonyPatch]
    public class NetworkPatches
    {
        [HarmonyPatch(typeof(NetworkController), "HostLobby")]
        [HarmonyPrefix]
        static void HostLobby_Prefix(ref int maxPlayers)
        {
            if (maxPlayers > Plugin.MaxPlayers.Value)
                maxPlayers = Plugin.MaxPlayers.Value;
        }

        [HarmonyPatch(typeof(SteamMatchmaking), "CreateLobby")]
        [HarmonyPrefix]
        static void CreateLobby_Prefix(ref int cMaxMembers)
        {
            if (cMaxMembers > Plugin.MaxPlayers.Value)
                cMaxMembers = Plugin.MaxPlayers.Value;
        }
    }
}