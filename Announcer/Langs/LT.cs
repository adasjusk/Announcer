using System.ComponentModel;
namespace Announcer.Langs
{
    public class LT : ILang
    {
        [Description("CASSIE message when scan starts")]
        public string ScanStartMessageCassie { get; set; } = "PILNAS ZAIDEJU SKENAVIMAS PO {LENGTH} SEKUNDZIU";

        [Description("Caption when scan starts")]
        public string ScanStartMessageCaption { get; set; } = "Pilnas zaideju skenavimas po {LENGTH} sekundziu";

        [Description("CASSIE message when nobody is detected")]
        public string ScanNobodyMessageCassie { get; set; } = "SKENAVIMAS BAIGTAS . OBJEKTU NERASTA";

        [Description("Caption when nobody is detected")]
        public string ScanNobodyMessageCaption { get; set; } = "Skenavimas baigtas. Objektu nerasta";

        [Description("CASSIE message for scan complete prefix")]
        public string ScanCompleteCassie { get; set; } = "OBJEKTAS NUSKENUOTAS . RASTA ";

        [Description("Caption for scan complete prefix")]
        public string ScanCompleteCaption { get; set; } = "Objektas nuskenuotas. Rasta ";

        [Description("CASSIE format for SCP count (singular)")]
        public string ScpSingularCassie { get; set; } = "{COUNT} SCP OBJEKTAS";

        [Description("CASSIE format for SCP count (plural)")]
        public string ScpPluralCassie { get; set; } = "{COUNT} SCP OBJEKTAI";

        [Description("Caption format for SCP count (singular)")]
        public string ScpSingularCaption { get; set; } = "{COUNT} SCP";

        [Description("Caption format for SCP count (plural)")]
        public string ScpPluralCaption { get; set; } = "{COUNT} SCP";

        [Description("CASSIE format for Class-D count (singular)")]
        public string ClassDSingularCassie { get; set; } = "{COUNT} D KLASES PERSONALAS";

        [Description("CASSIE format for Class-D count (plural)")]
        public string ClassDPluralCassie { get; set; } = "{COUNT} D KLASES PERSONALAS";

        [Description("Caption format for Class-D count (singular)")]
        public string ClassDSingularCaption { get; set; } = "{COUNT} D-Klase";

        [Description("Caption format for Class-D count (plural)")]
        public string ClassDPluralCaption { get; set; } = "{COUNT} D-Klase";

        [Description("CASSIE format for Facility Guard count (singular)")]
        public string GuardSingularCassie { get; set; } = "{COUNT} OBJEKTO SARGAS";

        [Description("CASSIE format for Facility Guard count (plural)")]
        public string GuardPluralCassie { get; set; } = "{COUNT} OBJEKTO SARGAI";

        [Description("Caption format for Facility Guard count (singular)")]
        public string GuardSingularCaption { get; set; } = "{COUNT} Objekto Sargas";

        [Description("Caption format for Facility Guard count (plural)")]
        public string GuardPluralCaption { get; set; } = "{COUNT} Objekto Sargai";

        [Description("CASSIE format for Chaos Insurgent count (singular)")]
        public string ChaosSingularCassie { get; set; } = "{COUNT} CHAOSO SUKILELLIS";

        [Description("CASSIE format for Chaos Insurgent count (plural)")]
        public string ChaosPluralCassie { get; set; } = "{COUNT} CHAOSO SUKILELIAI";

        [Description("Caption format for Chaos Insurgent count (singular)")]
        public string ChaosSingularCaption { get; set; } = "{COUNT} Chaoso Sukilelis";

        [Description("Caption format for Chaos Insurgent count (plural)")]
        public string ChaosPluralCaption { get; set; } = "{COUNT} Chaoso Sukileliai";

        [Description("CASSIE format for MTF count (singular)")]
        public string MtfSingularCassie { get; set; } = "{COUNT} MTF VIENETAS";

        [Description("CASSIE format for MTF count (plural)")]
        public string MtfPluralCassie { get; set; } = "{COUNT} MTF VIENETAI";

        [Description("Caption format for MTF count (singular)")]
        public string MtfSingularCaption { get; set; } = "{COUNT} MTF";

        [Description("Caption format for MTF count (plural)")]
        public string MtfPluralCaption { get; set; } = "{COUNT} MTF";

        [Description("CASSIE format for Scientist count (singular)")]
        public string ScientistSingularCassie { get; set; } = "{COUNT} MOKSLININKAS";

        [Description("CASSIE format for Scientist count (plural)")]
        public string ScientistPluralCassie { get; set; } = "{COUNT} MOKSLININKAI";

        [Description("Caption format for Scientist count (singular)")]
        public string ScientistSingularCaption { get; set; } = "{COUNT} Mokslininkas";

        [Description("Caption format for Scientist count (plural)")]
        public string ScientistPluralCaption { get; set; } = "{COUNT} Mokslininkai";
}   }