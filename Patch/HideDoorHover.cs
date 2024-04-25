using HarmonyLib;

namespace HiddenDoors.Patch;

[HarmonyPatch]
public class HideDoorHover
{
    [HarmonyPatch(typeof(Door), nameof(Door.GetHoverName))]
    [HarmonyPostfix]
    private static void DoorHoverNamePatch(Door __instance, ref string __result)
    {
        if (__instance && __instance.name.StartsWith("Hideen_Door")) __result = "";
    }

    [HarmonyPatch(typeof(Door), nameof(Door.GetHoverText))]
    [HarmonyPostfix]
    private static void DoorHoverTextPatch(Door __instance, ref string __result)
    {
        if (__instance && __instance.name.StartsWith("Hideen_Door")) __result = "";
    }
}