using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using VkFinalCase.Base.Model;
using System.ComponentModel.DataAnnotations.Schema;

namespace VkFinalCase.Base
{
    [Table("Order", Schema = "dbo")]
    public class Order:Payment
    {
        public Guid BillingId { get; set; }
        public virtual BillingInfo BillingInfo { get; set; }
        public Guid ReferenceNumber { get; set; }
        public string ReceiverName { get; set; }
        public Address ReceiverAddress { get; set; }        
        public decimal TotalCost { get; set; }
        public Guid PaymentId { get; set; }

        public virtual List<Product> Products { get; set; }
        public virtual Payment Payment { get; set; }
    }

    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.Property(x => x.InsertDate).IsRequired();
            builder.Property(x => x.UpdateDate).IsRequired(false);
            builder.Property(x => x.IsActive).IsRequired();

            builder.Property(x => x.BillingId).IsRequired();
            builder.Property(x => x.ReferenceNumber).IsRequired();
            builder.Property(x => x.ReceiverName).IsRequired();
            builder.Property(x => x.ReceiverAddress).IsRequired();
            builder.Property(x => x.TotalCost).IsRequired();
            builder.Property(x => x.PaymentId).IsRequired();

            builder.HasIndex(x => x.BillingId);

            builder.HasOne(x => x.Payment)
                .WithOne()
                .IsRequired();

            builder.Ignore("ReceiverAddress");
        }
    }
}
