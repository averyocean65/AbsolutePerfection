using HarmonyLib;

namespace AP.Patches {
    [HarmonyPatch]
    public static class PlayerPatches {
        [HarmonyPatch(typeof(NewMovement), nameof(NewMovement.GetHurt))]
        [HarmonyPostfix]
        public static void GetHurtPatch(
            int damage,
            bool invincible,
            float scoreLossMultiplier = 1f,
            bool explosion = false,
            bool instablack = false,
            float hardDamageMultiplier = 0.35f,
            bool ignoreInvincibility = false) {
            if (invincible && !ignoreInvincibility) {
                return;
            }
            
            if (ModConfig.Enabled.GetValue() && damage > 0) {
                SceneHelper.RestartScene();
            }
        }
    }
}