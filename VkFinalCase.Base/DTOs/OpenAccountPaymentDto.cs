using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkFinalCase.Base.Enums;

namespace VkFinalCase.Base.DTOs
{
    public class OpenAccountPaymentDto
    {
        public Guid AccountId { get; set; }
        public decimal CreditAmount { get; set; }
        public PaymentStatus Status { get; set; }
        public decimal Amount { get; set; }
    }
}
