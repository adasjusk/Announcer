using System.ComponentModel;
namespace Announcer.Langs
{
    public class EN : ILang
    {
        [Description("CASSIE message when scan starts")]
        public string ScanStartMessageCassie { get; set; } = "FULL FACILITY SCAN IN {LENGTH} SECONDS";

        [Description("Caption when scan starts")]
        public string ScanStartMessageCaption { get; set; } = "Full facility scan in {LENGTH} seconds";

        [Description("CASSIE message when nobody is detected")]
        public string ScanNobodyMessageCassie { get; set; } = "SCAN COMPLETE . NO SUBJECTS DETECTED";

        [Description("Caption when nobody is detected")]
        public string ScanNobodyMessageCaption { get; set; } = "Scan complete. No subjects detected";

        [Description("CASSIE message for scan complete prefix")]
        public string ScanCompleteCassie { get; set; } = "SCANNED FACILITY . FOUND ";

        [Description("Caption for scan complete prefix")]
        public string ScanCompleteCaption { get; set; } = "Scanned Facility. Found ";

        [Description("CASSIE format for SCP count (singular)")]
        public string ScpSingularCassie { get; set; } = "{COUNT} SCP SUBJECT";

        [Description("CASSIE format for SCP count (plural)")]
        public string ScpPluralCassie { get; set; } = "{COUNT} SCP SUBJECTS";

        [Description("Caption format for SCP count (singular)")]
        public string ScpSingularCaption { get; set; } = "{COUNT} SCP";

        [Description("Caption format for SCP count (plural)")]
        public string ScpPluralCaption { get; set; } = "{COUNT} SCPs";

        [Description("CASSIE format for Class-D count (singular)")]
        public string ClassDSingularCassie { get; set; } = "{COUNT} CLASS D PERSONNEL";

        [Description("CASSIE format for Class-D count (plural)")]
        public string ClassDPluralCassie { get; set; } = "{COUNT} CLASS D PERSONNEL";

        [Description("Caption format for Class-D count (singular)")]
        public string ClassDSingularCaption { get; set; } = "{COUNT} Class-D";

        [Description("Caption format for Class-D count (plural)")]
        public string ClassDPluralCaption { get; set; } = "{COUNT} Class-D";

        [Description("CASSIE format for Facility Guard count (singular)")]
        public string GuardSingularCassie { get; set; } = "{COUNT} FACILITY GUARD";

        [Description("CASSIE format for Facility Guard count (plural)")]
        public string GuardPluralCassie { get; set; } = "{COUNT} FACILITY GUARDS";

        [Description("Caption format for Facility Guard count (singular)")]
        public string GuardSingularCaption { get; set; } = "{COUNT} Facility Guard";

        [Description("Caption format for Facility Guard count (plural)")]
        public string GuardPluralCaption { get; set; } = "{COUNT} Facility Guards";

        [Description("CASSIE format for Chaos Insurgent count (singular)")]
        public string ChaosSingularCassie { get; set; } = "{COUNT} CHAOS INSURGENT";

        [Description("CASSIE format for Chaos Insurgent count (plural)")]
        public string ChaosPluralCassie { get; set; } = "{COUNT} CHAOS INSURGENTS";

        [Description("Caption format for Chaos Insurgent count (singular)")]
        public string ChaosSingularCaption { get; set; } = "{COUNT} Chaos Insurgent";

        [Description("Caption format for Chaos Insurgent count (plural)")]
        public string ChaosPluralCaption { get; set; } = "{COUNT} Chaos Insurgents";

        [Description("CASSIE format for MTF count (singular)")]
        public string MtfSingularCassie { get; set; } = "{COUNT} MTF UNIT";

        [Description("CASSIE format for MTF count (plural)")]
        public string MtfPluralCassie { get; set; } = "{COUNT} MTF UNITS";

        [Description("Caption format for MTF count (singular)")]
        public string MtfSingularCaption { get; set; } = "{COUNT} NTF";

        [Description("Caption format for MTF count (plural)")]
        public string MtfPluralCaption { get; set; } = "{COUNT} NTFs";

        [Description("CASSIE format for Scientist count (singular)")]
        public string ScientistSingularCassie { get; set; } = "{COUNT} SCIENTIST";

        [Description("CASSIE format for Scientist count (plural)")]
        public string ScientistPluralCassie { get; set; } = "{COUNT} SCIENTISTS";

        [Description("Caption format for Scientist count (singular)")]
        public string ScientistSingularCaption { get; set; } = "{COUNT} Scientist";

        [Description("Caption format for Scientist count (plural)")]
        public string ScientistPluralCaption { get; set; } = "{COUNT} Scientists";
}   }