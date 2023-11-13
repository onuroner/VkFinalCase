using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkFinalCase.Base.DTOs
{
    public class EftTransactionDto
    {
        public Guid AccountId { get; set; }
        public string ReferenceNumber { get; set; }
        public string ReceiverName { get; set; }
        public Address ReceiverAddress { get; set; }
        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }
        public decimal Amount { get; set; }
    }
}
