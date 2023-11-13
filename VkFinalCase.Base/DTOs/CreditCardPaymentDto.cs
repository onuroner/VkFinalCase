using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkFinalCase.Base.DTOs
{
    public class CreditCardPaymentDto
    {
        public Guid AccountId { get; set; }
        public string CardHolder { get; set; }
        public long CardNumber { get; set; }
        public string Cvv { get; set; } // nnn
        public DateTime ExpiryDate { get; set; } // DDyy
        public int? ExpenseLimit { get; set; }
        public decimal Amount { get; set; }
    }
}
