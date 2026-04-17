using AUU;
using BepInEx;
using Configgy;
using HarmonyLib;
using UnityEngine.SceneManagement;

namespace AP {
	[BepInPlugin(PluginInfo.GUID, PluginInfo.NAME, PluginInfo.VERSION)]
	public class Plugin : BaseUnityPlugin {
		private static class PluginInfo {
			public const string GUID = "com.averyocean65.absoluteperfection";
			public const string NAME = "Absolute Perfection";
			public const string VERSION = "1.0.0";
		}

		private void Awake() {
			Harmony harmony = new Harmony(PluginInfo.GUID);
			harmony.PatchAll();

			ConfigBuilder builder = new ConfigBuilder(PluginInfo.GUID, "Absolute Perfection");
			builder.BuildAll();

			SceneManager.sceneLoaded += (scene, mode) => {
				if (!SceneUtils.IsInLevel()) {
					return;
				}

				if (!ModConfig.Enabled.GetValue() || !ModConfig.ShowWarning.GetValue()) {
					return;
				}
				
				HudMessageReceiver.Instance.SendHudMessage("<color=red>Absolute Perfection</color> is enabled. You can disable it or this warning in the <color=#00FFFF>Configgy</color> settings.");
			};
		}
	}
}