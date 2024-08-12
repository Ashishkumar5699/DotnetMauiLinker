using Sonaar.Domain.Enum;

namespace Sonaar.Domain.Dto.CustomerDirectory
{
    public class ConsumerDTO
	{
        public string ContactPrifix { get; set; }

        public string ContactFirstName { get; set; }

        public string ContactLastName { get; set; }

        public string ContactPhoneNumber { get; set; }

        public string ContactAddress1 { get; set; }

        public string ContactAddress2 { get; set; }

        public string ContactLandMark { get; set; }

        public string ContactCity { get; set; }

        public string ContactState { get; set; }

        public string ContactPinCode { get; set; }

        public string AdharNumber { get; set; }

        public string PanNumber { get; set; }

        public string CustmorGSTNumber { get; set; }

        public string CustmorCountry { get; set; }

        public string CustmorZipCode { get; set; }

        public ContactType ContactType { get; set; }

    }
}

