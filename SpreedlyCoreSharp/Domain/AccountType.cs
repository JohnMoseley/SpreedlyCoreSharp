using System.Xml.Serialization;

namespace SpreedlyCoreSharp.Domain
{
    public enum PaymentMethodType
    {
        [XmlEnum("")]
        None = 0,

        [XmlEnum("credit_card")]
        CreditCard,

        [XmlEnum("sprel")]
        SPREL,

        [XmlEnum("third_party_token")]
        ThirdParty,

        [XmlEnum("bank_account")]
        BankAccount
    }
}
