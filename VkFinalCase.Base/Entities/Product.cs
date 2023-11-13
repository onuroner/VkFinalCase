using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkFinalCase.Base.Model;

namespace VkFinalCase.Base
{
    [Table("Product", Schema = "dbo")]
    public class Product:BaseEntity
    {
        public string Title { get; set; }
        public decimal Cost { get; set; }
        public int Stock { get; set; }
    }

    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x =>  x.Title).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Cost).IsRequired();
            builder.Property(x => x.Stock).IsRequired();
        }
    }
}
