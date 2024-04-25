using HarmonyLib;

#pragma warning disable CS8509 // The switch expression does not handle all possible values of its input type (it is not exhaustive).

namespace HiddenDoors.Patch;

[UsedImplicitly, HarmonyPatch(typeof(ZNetScene), nameof(ZNetScene.Awake)), HarmonyWrapSafe]
file class ReplaceWithVanila
{
    [UsedImplicitly, HarmonyPostfix]
    private static void Postfix(ZNetScene __instance)
    {
        TryFixDoor("Hideen_Door_Stone_2x2", "stone_wall_2x1");
        TryFixDoor("Hideen_Door_Stone_2x3", "stone_wall_2x1");
        TryFixDoor("Hideen_Door_Stone_4x2", "stone_wall_4x2");
        TryFixDoor("Hideen_Door_Wood", "woodwall");
    }

    private static void TryFixDoor(string name, string origName)
    {
        try
        {
            var door = ZNetScene.instance.GetPrefab(name)?.GetComponent<Piece>();
            var origPiece = ZNetScene.instance.GetPrefab(origName)?.GetComponent<Piece>();
            var woodDoorOrig = ZNetScene.instance.GetPrefab("wood_door")?.GetComponent<Piece>();
            if (!door || !woodDoorOrig || !origPiece) return;
            var doorWearNTear = door.GetComponent<WearNTear>();
            var origWearNTear = origPiece.GetComponent<WearNTear>();
            var woodDoorOrigWearNTear = woodDoorOrig.GetComponent<WearNTear>();
            var doorDoorComp = door.GetComponent<Door>();
            var woodDoorOrigDoorComp = woodDoorOrig.GetComponent<Door>();
            Door origDoor = null;
            if (door.name.Contains("Wood"))
            {
                origDoor = woodDoorOrigDoorComp;
            } else if (door.name.Contains("Stone"))
            {
                origDoor = woodDoorOrigDoorComp;
            } else if (door.name.Contains("Marble")) throw new Exception("Marble door not supported");
            else throw new Exception("Unknown door type");

            foreach (var mode in new List<string>() { "New", "Worn", "Broken" })
            {
                var parrent = mode switch
                {
                    "New" => doorWearNTear.m_new,
                    "Worn" => doorWearNTear.m_worn,
                    "Broken" => doorWearNTear.m_broken
                };

                var origParrent = mode switch
                {
                    "New" => origWearNTear.m_new,
                    "Worn" => origWearNTear.m_worn,
                    "Broken" => origWearNTear.m_broken
                };

                foreach (var rend in parrent.GetComponentsInChildren<Renderer>())
                {
                    var origRend = origParrent.transform.FindChildByName(rend.name)?.GetComponent<Renderer>();
                    if (origRend) rend.sharedMaterials = origRend.sharedMaterials;
                    else DebugWarning($"Skipping '{rend.name}' not found in {origPiece.name}. Prefab: {door.name}");
                }
            }

            if (!door.name.Contains("Stone"))
            {
                doorDoorComp.m_openEffects = origDoor.m_openEffects;
                doorDoorComp.m_closeEffects = origDoor.m_closeEffects;
                doorDoorComp.m_lockedEffects = origDoor.m_lockedEffects;
            }

            var doorAudioSource = doorDoorComp.m_openEffects.m_effectPrefabs[0].m_prefab.GetComponent<AudioSource>();
            var origAudioSource = origDoor.m_openEffects.m_effectPrefabs[0].m_prefab.GetComponent<AudioSource>();
            doorAudioSource.outputAudioMixerGroup = origAudioSource.outputAudioMixerGroup;
            doorAudioSource.priority = origAudioSource.priority;
            doorAudioSource.volume = origAudioSource.volume;
            doorAudioSource.pitch = origAudioSource.pitch;
            doorAudioSource.panStereo = origAudioSource.panStereo;
            doorAudioSource.spread = origAudioSource.spread;
            doorAudioSource.dopplerLevel = origAudioSource.dopplerLevel;
            doorAudioSource.rolloffMode = origAudioSource.rolloffMode;
            doorAudioSource.minDistance = origAudioSource.minDistance;
            doorAudioSource.maxDistance = origAudioSource.maxDistance;

            door.m_placeEffect = origPiece.m_placeEffect;
            doorWearNTear.m_destroyedEffect = origWearNTear.m_destroyedEffect;
            doorWearNTear.m_hitEffect = origWearNTear.m_hitEffect;
            doorWearNTear.m_switchEffect = origWearNTear.m_switchEffect;
        }
        catch (Exception e)
        {
            DebugError($"Failed to fix door '{name}': {e.Message}");
        }
    }
}