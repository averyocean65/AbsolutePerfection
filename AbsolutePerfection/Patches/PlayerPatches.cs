using HarmonyLib;

namespace AP.Patches {
    [HarmonyPatch]
    public static class PlayerPatches {
        [HarmonyPatch(typeof(NewMovement), nameof(NewMovement.GetHurt))]
        [HarmonyPostfix]
        public static void GetHurtPatch() {
            if (ModConfig.Enabled.GetValue()) {
                SceneHelper.RestartScene();
            }
        }
    }
}