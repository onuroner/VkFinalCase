using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkFinalCase.Base.Model;
using VkFinalCase.Base.PaymentTypes;
using System.ComponentModel.DataAnnotations.Schema;

namespace VkFinalCase.Base
{
    [Table("BillingInfo", Schema = "dbo")]
    public class BillingInfo:BaseEntity
    {
        public Guid DealerId { get; set; }
        public string BillingNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BillingAddress { get; set; }
        public Guid TaxId { get; set; }
        public string TaxOffice { get; set;}
    }

    public class BillingInfoConfiguration : IEntityTypeConfiguration<BillingInfo>
    {
        public void Configure(EntityTypeBuilder<BillingInfo> builder)
        {
            builder.Property(x => x.InsertDate).IsRequired();
            builder.Property(x => x.UpdateDate).IsRequired(false);
            builder.Property(x => x.IsActive).IsRequired();

            builder.Property(x => x.FirstName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.LastName).IsRequired().HasMaxLength(50);
            builder.Property(x => x.BillingAddress).IsRequired();
            builder.Property(x => x.TaxId).IsRequired();
            builder.Property(x => x.TaxOffice).IsRequired();

            builder.HasIndex(x => x.BillingNumber);
        }
    }
}
