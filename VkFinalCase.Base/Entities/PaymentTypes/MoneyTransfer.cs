using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using VkFinalCase.Base.Enums;

using VkFinalCase.Base.Model;

namespace VkFinalCase.Base.PaymentTypes
{
    [Table("MoneyTransfer", Schema = "dbo")]
    public class MoneyTransfer:Payment
    {
        
        public string ReferenceNumber { get; set; }
        public string Description { get; set; }
        public DateTime TransactionDate { get; set; }
    }

    public class MoneyTransferConfiguration : IEntityTypeConfiguration<MoneyTransfer>
    {
        public void Configure(EntityTypeBuilder<MoneyTransfer> builder)
        {
            builder.Property(x => x.InsertDate).IsRequired();
            builder.Property(x => x.UpdateDate).IsRequired(false);
            builder.Property(x => x.IsActive).IsRequired();

            builder.Property(x => x.AccountId).IsRequired();
            builder.Property(x => x.ReferenceNumber).IsRequired();
            builder.Property(x => x.Amount).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(50);
            builder.Property(x => x.TransactionDate).IsRequired();
            builder.Property(x => x.Status).IsRequired();

            builder.HasIndex(x => x.AccountId);
        }
    }
}
