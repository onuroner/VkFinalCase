using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkFinalCase.Base.Enums;
using VkFinalCase.Base.Model;

namespace VkFinalCase.Base
{
    public class Payment:BaseEntity
    {
        public Guid AccountId { get; set; }
        public virtual Account Account { get; set; }
        public decimal Amount { get; set; }
        public PaymentStatus Status { get; set; }
    }
}
