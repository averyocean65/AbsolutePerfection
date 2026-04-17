using Configgy;

namespace AP {
    public static class ModConfig {
        [Configgable]
        public static ConfigToggle Enabled = new ConfigToggle(true);
        
        [Configgable]
        public static ConfigToggle ShowWarning = new ConfigToggle(true);
    }
}