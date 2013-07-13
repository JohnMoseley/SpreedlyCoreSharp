using System.ComponentModel;
using System.Xml.Serialization;

namespace SpreedlyCoreSharp.Domain
{
    public enum BankAccountType
    {
        [Description("Unknown")]
        [XmlEnum("")]
        None = 0,

        [Description("Checking")]
        [XmlEnum("checking")]
        Checking,

        [Description("Savings")]
        [XmlEnum("savings")]
        Savings
    }
}
