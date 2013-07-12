using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SpreedlyCoreSharp.Domain
{
    [XmlRoot("payment_method")]
    public class PaymentMethod
    {
        public class Error
        {
            [XmlAttribute("attribute")]
            public string Field { get; set; }

            [XmlAttribute("key")]
            public string Key { get; set; }

            [XmlText]
            public string Message { get; set; }
        }

        [XmlElement("token")]
        public string Token { get; set; }

        [XmlElement("created_at")]
        public DateTime CreatedAt { get; set; }

        [XmlElement("updated_at")]
        public DateTime UpdatedAt { get; set; }

        [XmlElement("payment_method_type")]
        [DefaultValue(PaymentMethodType.None)]
        public PaymentMethodType PaymentMethodType { get; set; }

        [XmlElement("last_four_digits")]
        public string LastFourDigits { get; set; }

        [XmlElement("number")]
        public string Number { get; set; }

        [XmlElement("verification_value")]
        public string VerificationValue { get; set; }

        [XmlElement("card_type")]
        [DefaultValue(CardType.None)]
        public CardType CardType { get; set; }

        [XmlElement("bank_name")]
        public string BankName { get; set; }

        [XmlElement("account_type")]
        [DefaultValue(BankAccountType.None)]
        public BankAccountType BankAccountType { get; set; }

        [XmlElement("account_number")]
        public string BankAccountNumber { get; set; }

        [XmlElement("routing_number")]
        public string BankRoutingNumber { get; set; }

        [XmlElement("first_name")]
        public string FirstName { get; set; }

        [XmlElement("last_name")]
        public string LastName { get; set; }

        [XmlElement("full_name")]
        public string FullName { get; set; }

        [XmlElement("month")]
        [DefaultValue(0)]
        public int Month { get; set; }

        [XmlElement("year")]
        [DefaultValue(0)]
        public int Year { get; set; }

        [XmlElement("email")]
        public string Email { get; set; }

        [XmlElement("address1")]
        public string Address1 { get; set; }

        [XmlElement("address2")]
        public string Address2 { get; set; }

        [XmlElement("city")]
        public string City { get; set; }

        [XmlElement("state")]
        public string State { get; set; }

        [XmlElement("zip")]
        public string Zip { get; set; }

        [XmlElement("country")]
        public string Country { get; set; }

        [XmlElement("phone_number")]
        public string PhoneNumber { get; set; }

        [XmlArray("errors")]
        [XmlArrayItem("error")]
        public List<Error> Errors { get; set; }

        public object Data { get; set; }
    }
}
