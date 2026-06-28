using System.ComponentModel;
namespace Announcer.Langs
{
    public class FR : ILang
    {
        [Description("CASSIE message when scan starts")]
        public string ScanStartMessageCassie { get; set; } = "SCAN COMPLET DE LINSTALLATION DANS {LENGTH} SECONDES";

        [Description("Caption when scan starts")]
        public string ScanStartMessageCaption { get; set; } = "Scan complet de l'installation dans {LENGTH} secondes";

        [Description("CASSIE message when nobody is detected")]
        public string ScanNobodyMessageCassie { get; set; } = "SCAN TERMINE . AUCUN SUJET DETECTE";

        [Description("Caption when nobody is detected")]
        public string ScanNobodyMessageCaption { get; set; } = "Scan termine. Aucun sujet detecte";

        [Description("CASSIE message for scan complete prefix")]
        public string ScanCompleteCassie { get; set; } = "INSTALLATION SCANNEE . TROUVE ";

        [Description("Caption for scan complete prefix")]
        public string ScanCompleteCaption { get; set; } = "Installation scannee. Trouve ";

        [Description("CASSIE format for SCP count (singular)")]
        public string ScpSingularCassie { get; set; } = "{COUNT} SUJET SCP";

        [Description("CASSIE format for SCP count (plural)")]
        public string ScpPluralCassie { get; set; } = "{COUNT} SUJETS SCP";

        [Description("Caption format for SCP count (singular)")]
        public string ScpSingularCaption { get; set; } = "{COUNT} SCP";

        [Description("Caption format for SCP count (plural)")]
        public string ScpPluralCaption { get; set; } = "{COUNT} SCPs";

        [Description("CASSIE format for Class-D count (singular)")]
        public string ClassDSingularCassie { get; set; } = "{COUNT} PERSONNEL CLASSE D";

        [Description("CASSIE format for Class-D count (plural)")]
        public string ClassDPluralCassie { get; set; } = "{COUNT} PERSONNEL CLASSE D";

        [Description("Caption format for Class-D count (singular)")]
        public string ClassDSingularCaption { get; set; } = "{COUNT} Classe-D";

        [Description("Caption format for Class-D count (plural)")]
        public string ClassDPluralCaption { get; set; } = "{COUNT} Classe-D";

        [Description("CASSIE format for Facility Guard count (singular)")]
        public string GuardSingularCassie { get; set; } = "{COUNT} GARDE DE LINSTALLATION";

        [Description("CASSIE format for Facility Guard count (plural)")]
        public string GuardPluralCassie { get; set; } = "{COUNT} GARDES DE LINSTALLATION";

        [Description("Caption format for Facility Guard count (singular)")]
        public string GuardSingularCaption { get; set; } = "{COUNT} Garde";

        [Description("Caption format for Facility Guard count (plural)")]
        public string GuardPluralCaption { get; set; } = "{COUNT} Gardes";

        [Description("CASSIE format for Chaos Insurgent count (singular)")]
        public string ChaosSingularCassie { get; set; } = "{COUNT} INSURGE DU CHAOS";

        [Description("CASSIE format for Chaos Insurgent count (plural)")]
        public string ChaosPluralCassie { get; set; } = "{COUNT} INSURGES DU CHAOS";

        [Description("Caption format for Chaos Insurgent count (singular)")]
        public string ChaosSingularCaption { get; set; } = "{COUNT} Insurge du Chaos";

        [Description("Caption format for Chaos Insurgent count (plural)")]
        public string ChaosPluralCaption { get; set; } = "{COUNT} Insurges du Chaos";

        [Description("CASSIE format for MTF count (singular)")]
        public string MtfSingularCassie { get; set; } = "{COUNT} UNITE MTF";

        [Description("CASSIE format for MTF count (plural)")]
        public string MtfPluralCassie { get; set; } = "{COUNT} UNITES MTF";

        [Description("Caption format for MTF count (singular)")]
        public string MtfSingularCaption { get; set; } = "{COUNT} MTF";

        [Description("Caption format for MTF count (plural)")]
        public string MtfPluralCaption { get; set; } = "{COUNT} MTFs";

        [Description("CASSIE format for Scientist count (singular)")]
        public string ScientistSingularCassie { get; set; } = "{COUNT} SCIENTIFIQUE";

        [Description("CASSIE format for Scientist count (plural)")]
        public string ScientistPluralCassie { get; set; } = "{COUNT} SCIENTIFIQUES";

        [Description("Caption format for Scientist count (singular)")]
        public string ScientistSingularCaption { get; set; } = "{COUNT} Scientifique";

        [Description("Caption format for Scientist count (plural)")]
        public string ScientistPluralCaption { get; set; } = "{COUNT} Scientifiques";
}   }