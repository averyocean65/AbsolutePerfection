using BepInEx;

namespace AP {
	[BepInPlugin(PluginInfo.GUID, PluginInfo.NAME, PluginInfo.VERSION)]
	public class Plugin : BaseUnityPlugin {
		private static class PluginInfo {
			public const string GUID = "com.a.absoluteperfection";
			public const string NAME = "Absolute Perfection";
			public const string VERSION = "1.0.0";
		}

		private void Start() {
		}
	}
}