using System.ComponentModel;
namespace Announcer
{
    public class Config
    {
        [Description("Automatically detect language from game translation files")]
        public bool AutoDetectLanguage { get; set; } = false;
        [Description("Language code to use (EN, DE, PL, LT, FR) when AutoDetectLanguage is false")]
        public string Language { get; set; } = "EN";
        [Description("Perform regular scanning throughout the round")]
        public bool RegularScanning { get; set; } = true;
        [Description("Time in seconds the scan takes to complete")]
        public float ScanLength { get; set; } = 90f;
        [Description("Continue scanning after the nuke detonates?")]
        public bool ScanAfterNuke { get; set; }
        [Description("Minutes to wait after a scan finishes before announcing next scan")]
        public int DelayAfterScanMinutes { get; set; } = 9;
}   }