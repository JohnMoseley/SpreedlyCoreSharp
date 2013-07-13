using System.ComponentModel;
using System.Xml.Serialization;

namespace SpreedlyCoreSharp.Domain
{
    public enum CardType
    {
        [Description("Unknown")]
        [XmlEnum("")]
        None = 0,

        [Description("Visa")]
        [XmlEnum("visa")]
        Visa,

        [Description("Master Card")]
        [XmlEnum("master")]
        MasterCard,

        [Description("American Express")]
        [XmlEnum("american_express")]
        AmericanExpress,

        [Description("Discover")]
        [XmlEnum("discover")]
        Discover,

        [Description("Dankort")]
        [XmlEnum("dankort")]
        Dankort,

        [Description("Diner's Club")]
        [XmlEnum("diners_club")]
        DinnersClub,

        [Description("JCB")]
        [XmlEnum("jcb")]
        JCB,

        [Description("Switch")]
        [XmlEnum("switch")]
        Switch,

        [Description("Solo")]
        [XmlEnum("solo")]
        Solo,

        [Description("Maestro")]
        [XmlEnum("maestro")]
        Maestro,

        [Description("Forbrugsforeningen")]
        [XmlEnum("forbrugsforeningen")]
        Forbrugsforeningen,

        [Description("Laser")]
        [XmlEnum("laser")]
        Laser
    }
}
