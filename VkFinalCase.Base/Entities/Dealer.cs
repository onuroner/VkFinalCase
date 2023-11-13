using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkFinalCase.Base.PaymentTypes;
using VkFinalCase.Base.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace VkFinalCase.Base
{
    [Table("Dealer", Schema = "dbo")]
    public class Dealer:BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }       
        public Guid UserId { get; set; }
        public Guid AccountId { get; set; }
        public Guid BillingId { get; set; }

       
        public virtual BillingInfo BillingInfo { get; set; }
        
        public virtual Address Address { get; set; }
        
        public virtual Account Account { get; set; }
        
        public virtual UserCredential User { get; set; }
    }

    public class DealerConfiguration : IEntityTypeConfiguration<Dealer>
    {
        public void Configure(EntityTypeBuilder<Dealer> builder)
        {
            builder.Property(x => x.InsertDate).IsRequired();
            builder.Property(x => x.UpdateDate).IsRequired(false);
            builder.Property(x => x.IsActive).IsRequired();

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.BillingInfo).IsRequired();
            builder.Property(x => x.UserId).IsRequired();
            builder.Property(x => x.AccountId).IsRequired();

            builder.Ignore("BillingInfo");

            builder.HasOne(x => x.Account)
                .WithOne(x => x.Dealer)
                .HasForeignKey<Account>()
                .IsRequired();
        }
    }
}
