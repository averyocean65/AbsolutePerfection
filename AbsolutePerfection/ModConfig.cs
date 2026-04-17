using Configgy;

namespace AP {
    public static class ModConfig {
        [Configgable]
        public static ConfigToggle Enabled = new ConfigToggle(false);
    }
}