using System;
namespace Sonaar.Domain.Bills
{
    public class GSTAmount
    {
        public decimal Discount { get; set; }

        private decimal _totalAfterDiscount;
        public decimal TotalAfterDiscount
        {
            get => Math.Round(_totalAfterDiscount,2);
            set => _totalAfterDiscount = Math.Round(_totalAfterDiscount, 0);
        }

        private decimal _cGSt; 
        public decimal CGSt 
        {
            get => Math.Round(_cGSt,2);
            set => _cGSt = Math.Round(_cGSt, 0);
        }

        private decimal _sGST;
        public decimal SGST 
        { 
            get => Math.Round(_sGST,2);
            set => _sGST = Math.Round(_sGST, 0);
        }

        private decimal _iGST;
        public decimal IGST 
        { 
            get => Math.Round(_iGST,2);
            set => _iGST = Math.Round(_iGST, 0);
        }

        private decimal _grandTotal; 
        public decimal GrandTotal 
        {
            get => Math.Round(_grandTotal,2);
            set => _grandTotal = Math.Round(_grandTotal, 0);
        }

        private decimal _totalBeforeDiscount; 
        public decimal TotalBeforeDiscount 
        {
            get => Math.Round(_totalBeforeDiscount,2);
            set => _totalBeforeDiscount = Math.Round(_totalBeforeDiscount, 0);
        }
    }
}