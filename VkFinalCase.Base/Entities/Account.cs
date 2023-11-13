using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkFinalCase.Base.Model;
using VkFinalCase.Base.PaymentTypes;

namespace VkFinalCase.Base
{
    [Table("Account", Schema = "dbo")]
    public class Account:BaseEntity
    {
        public Guid DealerId { get; set; }
        public Dealer Dealer { get; set; }
        public string Name { get; set; }
        public int AccountNumber { get; set; }
        public string IBAN { get; set; }
        [DefaultValue(0)]
        public decimal Balance { get; set; }
        public string CurrencyCode { get; set; }
        public DateTime OpenDate { get; set; }
        public DateTime? CloseDate { get; set; }

        public virtual List<EftTransaction> EftTransactions { get; set; }
        public virtual List<MoneyTransfer> MoneyTransfers { get; set; }
    }

    public class AccountConfiguration : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            builder.Property(x => x.InsertDate).IsRequired();
            builder.Property(x => x.UpdateDate).IsRequired(false);
            builder.Property(x => x.IsActive).IsRequired();

            builder.Property(x => x.Name).IsRequired().HasMaxLength(50);
            builder.Property(x => x.AccountNumber).IsRequired();
            builder.Property(x => x.IBAN).IsRequired().HasMaxLength(34);
            builder.Property(x => x.Balance).IsRequired().HasPrecision(18, 2);
            builder.Property(x => x.CurrencyCode).IsRequired().HasMaxLength(3);
            builder.Property(x => x.OpenDate).IsRequired();
            builder.Property(x => x.CloseDate).IsRequired(false);

            builder.HasIndex(x => x.AccountNumber).IsUnique(true);

            builder.HasMany(x => x.EftTransactions)
            .WithOne(x => x.Account)
            .HasForeignKey(x => x.AccountId)
            .IsRequired(true);
            builder.HasMany(x => x.MoneyTransfers)
            .WithOne(x => x.Account)
            .HasForeignKey(x => x.AccountId)
            .IsRequired(true);

            builder.HasOne(x => x.Dealer)
                .WithOne(x => x.Account)
                .HasForeignKey<Dealer>()
                .IsRequired();
        }
    }
}
