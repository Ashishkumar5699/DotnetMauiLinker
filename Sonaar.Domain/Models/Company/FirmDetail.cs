using System;
namespace Sonaar.Domain.Models.Company
{
    public class FirmDetail
    {
        public required string FirmName { get; set; }

        public required string FirmAddress { get; set; }

        public required string FirmGSTNumber { get; set; }

        public required string FirmPhoneNumber { get; set; }

        public string BankName { get; set; }
        
        public string AccountNumber { get; set; }
        
        public string AccountHolder { get; set; }

        public string Branch { get; set; }
        
        public string IfscCode { get; set; }
    }
}

