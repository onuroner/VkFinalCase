using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkFinalCase.Base.DTOs
{
    public class MoneyTransferDto
    {
        public Guid AccountId { get; set; }
        public string ReferenceNumber { get; set; }
        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
    }
}
