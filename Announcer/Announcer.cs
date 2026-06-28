using Announcer.Langs;
using LabApi.Events.Arguments.ServerEvents;
using LabApi.Events.Arguments.WarheadEvents;
using LabApi.Events.Handlers;
using LabApi.Features;
using LabApi.Features.Console;
using LabApi.Features.Wrappers;
using LabApi.Loader;
using LabApi.Loader.Features.Plugins;
using PlayerRoles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Announcer
{
    public class Announcer : Plugin<Config>
    {
        private CancellationTokenSource _scanCancellationToken;
        public static bool ScanInProgress;
        public override string Name => "Announcer";
        public override string Description => "Announces via CASSIE how many classes are left and how many players are in each class";
        public override string Author => "adasjusk";
        public override Version Version => new Version(2, 0, 0);
        public override Version RequiredApiVersion => new Version(1, 1, 7);
        public static Announcer Instance { get; private set; }
        private readonly Dictionary<string, ILang> _languages = new Dictionary<string, ILang>(StringComparer.OrdinalIgnoreCase);
        private ILang _lang;
        public override void Enable()
        {
            Instance = this;
            RegisterLanguages();
            if (Config.AutoDetectLanguage)
            {
                string detectedLang = DetectLanguageFromGame();
                if (detectedLang != null && _languages.ContainsKey(detectedLang))
                {
                    Config.Language = detectedLang;
                    Logger.Info($"Auto-detected language: {detectedLang}");
                }
                else
                {
                    Config.AutoDetectLanguage = false;
                    Config.Language = "EN";
                    Logger.Warn("Failed to auto-detect a supported language, defaulting to English");
                }
            }
            ApplyLanguage(Config.Language);
            ServerEvents.RoundStarted += OnRoundStarted;
            ServerEvents.RoundEnded += OnRoundEnded;
            WarheadEvents.Detonated += OnWarheadDetonated;
            Logger.Info($"{Name} v{Version} has been enabled!");
        }

        public override void Disable()
        {
            ServerEvents.RoundStarted -= OnRoundStarted;
            ServerEvents.RoundEnded -= OnRoundEnded;
            WarheadEvents.Detonated -= OnWarheadDetonated;
            _scanCancellationToken?.Cancel();
            _languages.Clear();
            _lang = null;
            Instance = null;
            Logger.Info($"{Name} has been disabled!");
        }

        private void RegisterLanguages()
        {
            _languages["EN"] = LoadLang<EN>("EN");
            _languages["DE"] = LoadLang<DE>("DE");
            _languages["PL"] = LoadLang<PL>("PL");
            _languages["LT"] = LoadLang<LT>("LT");
            _languages["FR"] = LoadLang<FR>("FR");
        }
        private T LoadLang<T>(string code) where T : class, ILang, new()
        {
            T fallback = new T();
            try
            {
                T loaded = ConfigurationLoader.LoadConfig<T>(this, $"Langs_{code}", false);
                if (loaded != null)
                    return loaded;
            }
            catch
            {
                // fall through
            }
            ConfigurationLoader.SaveConfig(this, fallback, $"Langs_{code}", false);
            return fallback;
        }
        private void ApplyLanguage(string lang)
        {
            if (lang == null || !_languages.TryGetValue(lang, out _lang) || _lang == null)
            {
                _lang = _languages["EN"];
                Logger.Warn($"Language '{lang}' is not supported, using English");
            }
        }
        private string DetectLanguageFromGame()
        {
            try
            {
                string[] possiblePaths = new string[]
                {
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SCP Secret Laboratory", "Translations"),
                    Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "SCP Secret Laboratory", "Translations"),
                    Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Translations")
                };

                foreach (string basePath in possiblePaths)
                {
                    if (!Directory.Exists(basePath))
                        continue;

                    string[] langFiles = Directory.GetFiles(basePath, "*.txt");
                    foreach (string file in langFiles)
                    {
                        string content = File.ReadAllText(file);
                        if (content.Contains("menus.general.") || content.Contains("gameplay.") || content.Contains("interface."))
                        {
                            string fileName = Path.GetFileNameWithoutExtension(file).ToUpperInvariant();
                            if (fileName == "ENGLISH" || fileName == "EN") return "EN";
                            if (fileName == "GERMAN" || fileName == "DE" || fileName == "DEUTSCH") return "DE";
                            if (fileName == "POLISH" || fileName == "PL" || fileName == "POLSKI") return "PL";
                            if (fileName == "LITHUANIAN" || fileName == "LT" || fileName == "LIETUVIU") return "LT";
                            if (fileName == "FRENCH" || fileName == "FR" || fileName == "FRANCAIS") return "FR";
                            return fileName.Length == 2 ? fileName : "EN";  
                }   }   }
                string configPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "SCP Secret Laboratory", "config_gameplay.txt");
                if (File.Exists(configPath))
                {
                    string[] lines = File.ReadAllLines(configPath);
                    foreach (string line in lines)
                    {
                        if (line.StartsWith("language=") || line.StartsWith("Language="))
                        {
                            string lang = line.Split('=')[1].Trim().ToUpperInvariant();
                            if (lang.Length >= 2)
                                return lang.Substring(0, 2);
            }   }   }   }
            catch (Exception ex)
            {
                Logger.Debug($"Language detection error: {ex.Message}");
            }
            return null;
        }
        private void OnRoundStarted()
        {
            ScanInProgress = false;
            _scanCancellationToken?.Cancel();
            _scanCancellationToken = new CancellationTokenSource();
            if (Config.RegularScanning)
            {
                Task.Run(() => ScanLoop(_scanCancellationToken.Token));
            }
        }
        private void OnRoundEnded(RoundEndedEventArgs _)
        {
            _scanCancellationToken?.Cancel();
            ScanInProgress = false;
        }
        private void OnWarheadDetonated(WarheadDetonatedEventArgs _)
        {
            if (!Config.ScanAfterNuke)
            {
                _scanCancellationToken?.Cancel();
            }
        }
        private async Task ScanLoop(CancellationToken cancellationToken)
        {
            try
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    while (Player.List.Count(p => p.IsAlive) < 1 && !cancellationToken.IsCancellationRequested)
                    {
                        await Task.Delay(1000, cancellationToken);
                    }
                    if (cancellationToken.IsCancellationRequested)
                        break;

                    if (ScanInProgress)
                    {
                        await Task.Delay(1000, cancellationToken);
                        continue;
                    }
                    ScanInProgress = true;
                    string cassie = _lang.ScanStartMessageCassie.Replace("{LENGTH}", Config.ScanLength.ToString());
                    string caption = _lang.ScanStartMessageCaption.Replace("{LENGTH}", Config.ScanLength.ToString());
                    Broadcast(cassie, caption);
                    await Task.Delay(TimeSpan.FromSeconds(Config.ScanLength), cancellationToken);
                    if (!cancellationToken.IsCancellationRequested)
                        PerformScan();

                    await Task.Delay(TimeSpan.FromMinutes(Config.DelayAfterScanMinutes), cancellationToken);
                    ScanInProgress = false;
                }
            }
            catch (OperationCanceledException)
            {
            }
            catch (Exception ex)
            {
                Logger.Error($"Error in scan loop: {ex}");
                ScanInProgress = false;
            }
        }
        public void PerformScan()
        {
            try
            {
                int scpCount = 0;
                int classDCount = 0;
                int scientistCount = 0;
                int guardCount = 0;
                int mtfCount = 0;
                int chaosCount = 0;
                foreach (Player item in Player.List)
                {
                    if (!item.IsAlive)
                        continue;

                    switch (item.Team)
                    {
                        case Team.SCPs:
                            scpCount++;
                            break;
                        case Team.ClassD:
                            classDCount++;
                            break;
                        case Team.Scientists:
                            scientistCount++;
                            break;
                        case Team.FoundationForces:
                            if (item.Role == RoleTypeId.FacilityGuard)
                                guardCount++;
                            else
                                mtfCount++;
                            break;
                        case Team.ChaosInsurgency:
                            chaosCount++;
                            break;
                    }
                }
                if (scpCount + classDCount + scientistCount + guardCount + mtfCount + chaosCount == 0)
                {
                    Broadcast(_lang.ScanNobodyMessageCassie, _lang.ScanNobodyMessageCaption);
                    ScanInProgress = false;
                    return;
                }
                List<string> cassieParts = new List<string>();
                List<string> captionParts = new List<string>();
                AddCount(cassieParts, captionParts, scpCount, _lang.ScpSingularCassie, _lang.ScpPluralCassie, _lang.ScpSingularCaption, _lang.ScpPluralCaption);
                AddCount(cassieParts, captionParts, classDCount, _lang.ClassDSingularCassie, _lang.ClassDPluralCassie, _lang.ClassDSingularCaption, _lang.ClassDPluralCaption);
                AddCount(cassieParts, captionParts, guardCount, _lang.GuardSingularCassie, _lang.GuardPluralCassie, _lang.GuardSingularCaption, _lang.GuardPluralCaption);
                AddCount(cassieParts, captionParts, chaosCount, _lang.ChaosSingularCassie, _lang.ChaosPluralCassie, _lang.ChaosSingularCaption, _lang.ChaosPluralCaption);
                AddCount(cassieParts, captionParts, mtfCount, _lang.MtfSingularCassie, _lang.MtfPluralCassie, _lang.MtfSingularCaption, _lang.MtfPluralCaption);
                AddCount(cassieParts, captionParts, scientistCount, _lang.ScientistSingularCassie, _lang.ScientistPluralCassie, _lang.ScientistSingularCaption, _lang.ScientistPluralCaption);

                string cassie = new StringBuilder(_lang.ScanCompleteCassie).Append(string.Join(" . ", cassieParts)).ToString();
                string caption = new StringBuilder(_lang.ScanCompleteCaption).Append(string.Join(", ", captionParts)).ToString();
                Broadcast(cassie, caption);
                ScanInProgress = false;
            }
            catch (Exception ex)
            {
                Logger.Error($"Error during scan: {ex}");
                ScanInProgress = false;
            }
        }
        public void ForceScan()
        {
            if (ScanInProgress)
            {
                Logger.Warn("A scan is already in progress!");
                return;
            }
            Logger.Info("Force scan initiated by external call");
            ScanInProgress = true;
            PerformScan();
        }
        private void AddCount(List<string> cassieParts, List<string> captionParts, int count,
            string singularCassie, string pluralCassie, string singularCaption, string pluralCaption)
        {
            if (count <= 0)
                return;

            cassieParts.Add((count == 1 ? singularCassie : pluralCassie).Replace("{COUNT}", count.ToString()));
            captionParts.Add((count == 1 ? singularCaption : pluralCaption).Replace("{COUNT}", count.ToString()));
        }

        private static void Broadcast(string cassie, string caption)
        {
            LabApi.Features.Wrappers.Announcer.Message(cassie, caption, true, 0f, 1f);
}   }   }