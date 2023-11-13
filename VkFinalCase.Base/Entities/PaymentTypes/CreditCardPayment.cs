using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkFinalCase.Base.Enums;

using VkFinalCase.Base.Model;

namespace VkFinalCase.Base.PaymentTypes
{
    [Table("CreditCardPayment", Schema = "dbo")]
    public class CreditCardPayment:Payment
    {
        public string CardHolder { get; set; }
        public long CardNumber { get; set; }
        public string Cvv { get; set; } // nnn
        public DateTime ExpiryDate { get; set; } // DDyy
        public int? ExpenseLimit { get; set; }
    }

    public class CreditCardPaymentConfiguration : IEntityTypeConfiguration<CreditCardPayment>
    {
        public void Configure(EntityTypeBuilder<CreditCardPayment> builder)
        {
            builder.Property(x => x.InsertDate).IsRequired();
            builder.Property(x => x.UpdateDate).IsRequired(false);
            builder.Property(x => x.IsActive).IsRequired();

            builder.Property(x => x.AccountId).IsRequired();
            builder.Property(x => x.CardHolder).IsRequired();
            builder.Property(x => x.CardNumber).IsRequired().HasMaxLength(16);
            builder.Property(x => x.Cvv).IsRequired().HasMaxLength(3);
            builder.Property(x => x.ExpiryDate).IsRequired();
            builder.Property(x => x.ExpenseLimit).IsRequired();
            builder.Property(x => x.Status).IsRequired();

            builder.HasIndex(x => x.CardHolder);

            builder.HasOne(x => x.Account);
        }
    }
}
