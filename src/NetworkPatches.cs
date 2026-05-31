using HarmonyLib;
using Network;
using Steamworks;

namespace IKnowaGuyMorePlayers.HarmonyPatches
{
    [HarmonyPatch]
    public class NetworkPatches
    {
        // Patch the HostLobby method to modify player count
        [HarmonyPatch(typeof(NetworkController), "HostLobby")]
        [HarmonyPrefix]
        static void HostLobby_Prefix(ref int maxPlayers)
        {
            // Override the max player count when hosting
            maxPlayers = Plugin.MaxPlayers.Value;
        }

        // Patch Steam lobby creation to allow more players
        [HarmonyPatch(typeof(SteamMatchmaking), "CreateLobby")]
        [HarmonyPrefix]
        static void CreateLobby_Prefix(ref int cMaxMembers)
        {
            // Override the lobby size for Steam
            cMaxMembers = Plugin.MaxPlayers.Value;
        }
    }
}