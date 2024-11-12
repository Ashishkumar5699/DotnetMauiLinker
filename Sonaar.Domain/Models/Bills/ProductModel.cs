using System;
namespace Sonaar.Domain.Bills
{
	public class ProductModel
	{
        public string Description { get; set; }

        public string HSN_Code { get; set; }

        public string Purity { get; set; }

        private decimal _weight; 
        public decimal Weight 
        {
            get => Math.Round(_weight,2);
            set => _weight = Math.Round(_weight, 0);
        }

        private decimal _rate; 
        public decimal Rate 
        { 
            get => Math.Round(_rate,2);
            set => _weight = Math.Round(_rate, 0);
        }

        private decimal _making_Charge; 
        public decimal Making_Charge 
        { 
            get => Math.Round(_making_Charge,2);
            set => _weight = Math.Round(_making_Charge, 0);
        }

        private decimal _amount;
        public decimal Amount 
        { 
            get => Math.Round(_amount,2);
            set => _weight = Math.Round(_amount, 0);
        }
    }
}

