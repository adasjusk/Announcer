using System.ComponentModel;
namespace Announcer.Langs
{
    public class DE : ILang
    {
        [Description("CASSIE message when scan starts")]
        public string ScanStartMessageCassie { get; set; } = "KOMPLETTER ANLAGEN SCAN IN {LENGTH} SEKUNDEN";

        [Description("Caption when scan starts")]
        public string ScanStartMessageCaption { get; set; } = "Kompletter Anlagen-Scan in {LENGTH} Sekunden";

        [Description("CASSIE message when nobody is detected")]
        public string ScanNobodyMessageCassie { get; set; } = "SCAN ABGESCHLOSSEN . KEINE SUBJEKTE ERKANNT";

        [Description("Caption when nobody is detected")]
        public string ScanNobodyMessageCaption { get; set; } = "Scan abgeschlossen. Keine Subjekte erkannt";

        [Description("CASSIE message for scan complete prefix")]
        public string ScanCompleteCassie { get; set; } = "ANLAGE GESCANNT . GEFUNDEN ";

        [Description("Caption for scan complete prefix")]
        public string ScanCompleteCaption { get; set; } = "Anlage gescannt. Gefunden ";

        [Description("CASSIE format for SCP count (singular)")]
        public string ScpSingularCassie { get; set; } = "{COUNT} SCP SUBJEKT";

        [Description("CASSIE format for SCP count (plural)")]
        public string ScpPluralCassie { get; set; } = "{COUNT} SCP SUBJEKTE";

        [Description("Caption format for SCP count (singular)")]
        public string ScpSingularCaption { get; set; } = "{COUNT} SCP";

        [Description("Caption format for SCP count (plural)")]
        public string ScpPluralCaption { get; set; } = "{COUNT} SCPs";

        [Description("CASSIE format for Class-D count (singular)")]
        public string ClassDSingularCassie { get; set; } = "{COUNT} KLASSE D PERSONAL";

        [Description("CASSIE format for Class-D count (plural)")]
        public string ClassDPluralCassie { get; set; } = "{COUNT} KLASSE D PERSONAL";

        [Description("Caption format for Class-D count (singular)")]
        public string ClassDSingularCaption { get; set; } = "{COUNT} Klasse-D";

        [Description("Caption format for Class-D count (plural)")]
        public string ClassDPluralCaption { get; set; } = "{COUNT} Klasse-D";

        [Description("CASSIE format for Facility Guard count (singular)")]
        public string GuardSingularCassie { get; set; } = "{COUNT} EINRICHTUNGSWACHE";

        [Description("CASSIE format for Facility Guard count (plural)")]
        public string GuardPluralCassie { get; set; } = "{COUNT} EINRICHTUNGSWACHEN";

        [Description("Caption format for Facility Guard count (singular)")]
        public string GuardSingularCaption { get; set; } = "{COUNT} Einrichtungswache";

        [Description("Caption format for Facility Guard count (plural)")]
        public string GuardPluralCaption { get; set; } = "{COUNT} Einrichtungswachen";

        [Description("CASSIE format for Chaos Insurgent count (singular)")]
        public string ChaosSingularCassie { get; set; } = "{COUNT} CHAOS AUFRUEHRER";

        [Description("CASSIE format for Chaos Insurgent count (plural)")]
        public string ChaosPluralCassie { get; set; } = "{COUNT} CHAOS AUFRUEHRER";

        [Description("Caption format for Chaos Insurgent count (singular)")]
        public string ChaosSingularCaption { get; set; } = "{COUNT} Chaos-Aufruhrer";

        [Description("Caption format for Chaos Insurgent count (plural)")]
        public string ChaosPluralCaption { get; set; } = "{COUNT} Chaos-Aufruhrer";

        [Description("CASSIE format for MTF count (singular)")]
        public string MtfSingularCassie { get; set; } = "{COUNT} MTF EINHEIT";

        [Description("CASSIE format for MTF count (plural)")]
        public string MtfPluralCassie { get; set; } = "{COUNT} MTF EINHEITEN";

        [Description("Caption format for MTF count (singular)")]
        public string MtfSingularCaption { get; set; } = "{COUNT} MTF";

        [Description("Caption format for MTF count (plural)")]
        public string MtfPluralCaption { get; set; } = "{COUNT} MTFs";

        [Description("CASSIE format for Scientist count (singular)")]
        public string ScientistSingularCassie { get; set; } = "{COUNT} WISSENSCHAFTLER";

        [Description("CASSIE format for Scientist count (plural)")]
        public string ScientistPluralCassie { get; set; } = "{COUNT} WISSENSCHAFTLER";

        [Description("Caption format for Scientist count (singular)")]
        public string ScientistSingularCaption { get; set; } = "{COUNT} Wissenschaftler";

        [Description("Caption format for Scientist count (plural)")]
        public string ScientistPluralCaption { get; set; } = "{COUNT} Wissenschaftler";
}   }