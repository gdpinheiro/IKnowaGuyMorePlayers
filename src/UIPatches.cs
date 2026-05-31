using HarmonyLib;
using UI.MainMenu;
using UnityEngine.UIElements;

namespace IKnowaGuyMorePlayers.HarmonyPatches
{
    [HarmonyPatch(typeof(HostPageController), "Show")]
    public static class UIPatches
    {
        [HarmonyPostfix]
        public static void HostPageController_Show_Postfix(HostPageController __instance)
        {
            DropdownField dropdown = __instance.maxPlayersDropdown;
            if (dropdown == null) return;

            int maxVal = Plugin.MaxPlayers.Value;
            int minVal = 2;

            var choices = dropdown.choices;
            int currentMax = minVal;
            for (int i = 0; i < choices.Count; i++)
            {
                string choice = choices[i];
                if (int.TryParse(choice, out int val) && val > currentMax)
                    currentMax = val;
            }

            for (int i = currentMax + 1; i <= maxVal; i++)
                choices.Add(i.ToString());

            if (int.TryParse(dropdown.value, out int currentVal))
            {
                if (currentVal > maxVal || currentVal < minVal)
                    dropdown.value = maxVal.ToString();
            }
        }
    }
}
