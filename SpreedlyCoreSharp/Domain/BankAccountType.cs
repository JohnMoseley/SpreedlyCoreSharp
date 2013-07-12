using System.ComponentModel;
using System.Xml.Serialization;

namespace SpreedlyCoreSharp.Domain
{
    public enum BankAccountType
    {
        [XmlEnum("")]
        None = 0,

        [XmlEnum("checking")]
        Checking,

        [XmlEnum("savings")]
        Savings
    }
}
