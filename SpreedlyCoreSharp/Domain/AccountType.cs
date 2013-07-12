using System.ComponentModel;
using System.Xml.Serialization;

namespace SpreedlyCoreSharp.Domain
{
    public enum PaymentMethodType
    {
        [XmlEnum("")]
        None = 0,

        [Description("Credit Card")]
        [XmlEnum("credit_card")]
        CreditCard,

        [XmlEnum("sprel")]
        SPREL,

        [Description("Third Party")]
        [XmlEnum("third_party_token")]
        ThirdParty,

        [Description("Bank Account")]
        [XmlEnum("bank_account")]
        BankAccount
    }
}
