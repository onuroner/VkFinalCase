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
    [Table("Address", Schema = "dbo")]
    public class Address:BaseEntity
    {
        public Guid DealerId { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string PostalCode { get; set; }
    }

    public class AddressConfiguration : IEntityTypeConfiguration<Address>
    {
        public void Configure(EntityTypeBuilder<Address> builder)
        {
            builder.Property(x => x.InsertDate).IsRequired();
            builder.Property(x => x.UpdateDate).IsRequired(false);
            builder.Property(x => x.IsActive).IsRequired();

            builder.Property(x => x.AddressLine1).IsRequired().HasMaxLength(50);
            builder.Property(x => x.AddressLine2).IsRequired().HasMaxLength(50);
            builder.Property(x => x.City).IsRequired().HasMaxLength(50);
            builder.Property(x => x.County).IsRequired().HasMaxLength(50);
            builder.Property(x => x.PostalCode).IsRequired().HasMaxLength(10);

            builder.HasIndex(x => x.DealerId);
        }
    }
}
