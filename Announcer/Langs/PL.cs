using System.ComponentModel;
namespace Announcer.Langs
{
    public class PL : ILang
    {
        [Description("CASSIE message when scan starts")]
        public string ScanStartMessageCassie { get; set; } = "PELNE SKANOWANIE OBIEKTU ZA {LENGTH} SEKUND";

        [Description("Caption when scan starts")]
        public string ScanStartMessageCaption { get; set; } = "Pelne skanowanie obiektu za {LENGTH} sekund";

        [Description("CASSIE message when nobody is detected")]
        public string ScanNobodyMessageCassie { get; set; } = "SKANOWANIE ZAKONCZONE . NIE WYKRYTO OBIEKTOW";

        [Description("Caption when nobody is detected")]
        public string ScanNobodyMessageCaption { get; set; } = "Skanowanie zakonczone. Nie wykryto obiektow";

        [Description("CASSIE message for scan complete prefix")]
        public string ScanCompleteCassie { get; set; } = "PRZESKANOWANO OBIEKT . WYKRYTO ";

        [Description("Caption for scan complete prefix")]
        public string ScanCompleteCaption { get; set; } = "Przeskanowano obiekt. Wykryto ";

        [Description("CASSIE format for SCP count (singular)")]
        public string ScpSingularCassie { get; set; } = "{COUNT} OBIEKT SCP";

        [Description("CASSIE format for SCP count (plural)")]
        public string ScpPluralCassie { get; set; } = "{COUNT} OBIEKTY SCP";

        [Description("Caption format for SCP count (singular)")]
        public string ScpSingularCaption { get; set; } = "{COUNT} SCP";

        [Description("Caption format for SCP count (plural)")]
        public string ScpPluralCaption { get; set; } = "{COUNT} SCP";

        [Description("CASSIE format for Class-D count (singular)")]
        public string ClassDSingularCassie { get; set; } = "{COUNT} PERSONEL KLASY D";

        [Description("CASSIE format for Class-D count (plural)")]
        public string ClassDPluralCassie { get; set; } = "{COUNT} PERSONEL KLASY D";

        [Description("Caption format for Class-D count (singular)")]
        public string ClassDSingularCaption { get; set; } = "{COUNT} Klasa-D";

        [Description("Caption format for Class-D count (plural)")]
        public string ClassDPluralCaption { get; set; } = "{COUNT} Klasa-D";

        [Description("CASSIE format for Facility Guard count (singular)")]
        public string GuardSingularCassie { get; set; } = "{COUNT} STRAZNIK";

        [Description("CASSIE format for Facility Guard count (plural)")]
        public string GuardPluralCassie { get; set; } = "{COUNT} STRAZNIKOW";

        [Description("Caption format for Facility Guard count (singular)")]
        public string GuardSingularCaption { get; set; } = "{COUNT} Straznik";

        [Description("Caption format for Facility Guard count (plural)")]
        public string GuardPluralCaption { get; set; } = "{COUNT} Straznikow";

        [Description("CASSIE format for Chaos Insurgent count (singular)")]
        public string ChaosSingularCassie { get; set; } = "{COUNT} REBELIANT CHAOSU";

        [Description("CASSIE format for Chaos Insurgent count (plural)")]
        public string ChaosPluralCassie { get; set; } = "{COUNT} REBELIANTOW CHAOSU";

        [Description("Caption format for Chaos Insurgent count (singular)")]
        public string ChaosSingularCaption { get; set; } = "{COUNT} Rebeliant Chaosu";

        [Description("Caption format for Chaos Insurgent count (plural)")]
        public string ChaosPluralCaption { get; set; } = "{COUNT} Rebeliantow Chaosu";

        [Description("CASSIE format for MTF count (singular)")]
        public string MtfSingularCassie { get; set; } = "{COUNT} JEDNOSTKA MTF";

        [Description("CASSIE format for MTF count (plural)")]
        public string MtfPluralCassie { get; set; } = "{COUNT} JEDNOSTEK MTF";

        [Description("Caption format for MTF count (singular)")]
        public string MtfSingularCaption { get; set; } = "{COUNT} MTF";

        [Description("Caption format for MTF count (plural)")]
        public string MtfPluralCaption { get; set; } = "{COUNT} MTF";

        [Description("CASSIE format for Scientist count (singular)")]
        public string ScientistSingularCassie { get; set; } = "{COUNT} NAUKOWIEC";

        [Description("CASSIE format for Scientist count (plural)")]
        public string ScientistPluralCassie { get; set; } = "{COUNT} NAUKOWCOW";

        [Description("Caption format for Scientist count (singular)")]
        public string ScientistSingularCaption { get; set; } = "{COUNT} Naukowiec";

        [Description("Caption format for Scientist count (plural)")]
        public string ScientistPluralCaption { get; set; } = "{COUNT} Naukowcow";
}   }