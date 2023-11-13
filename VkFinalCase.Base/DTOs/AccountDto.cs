using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkFinalCase.Base.DTOs
{
    public class AccountDto
    {
        public string Name { get; set; }
        public int AccountNumber { get; set; }
        public string IBAN { get; set; }
        [DefaultValue(0)]
        public decimal Balance { get; set; }
        public string CurrencyCode { get; set; }
    }
}
