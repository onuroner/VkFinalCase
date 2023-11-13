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
    [Table("OpenAccount", Schema = "dbo")]
    public class OpenAccountPayment:Payment
    {
        public decimal CreditAmount { get; set; }
        public PaymentStatus Status { get ; set; }
    }

    public class OpenAccountPaymentConfiguration : IEntityTypeConfiguration<OpenAccountPayment>
    {
        public void Configure(EntityTypeBuilder<OpenAccountPayment> builder)
        {
            builder.Property(x => x.InsertDate).IsRequired();
            builder.Property(x => x.UpdateDate).IsRequired(false);
            builder.Property(x => x.IsActive).IsRequired();

            builder.Property(x => x.AccountId).IsRequired();
            builder.Property(x => x.CreditAmount).IsRequired();
            builder.Property(x => x.Status).IsRequired();

            builder.HasIndex(x => x.AccountId);
        }
    }
}
