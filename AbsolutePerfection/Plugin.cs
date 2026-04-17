using BepInEx;
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
		}
	}
}