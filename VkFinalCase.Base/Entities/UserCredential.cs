using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkFinalCase.Base.Model;
using VkFinalCase.Base.PaymentTypes;

namespace VkFinalCase.Base
{
    [Table("UserVredentials", Schema = "dbo")]
    public class UserCredential:BaseEntity
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public Guid RoleId { get; set; }
        public Guid DealerId { get; set; }

        public virtual Role Role { get; set; }
    }

    public class UserCredentialConfiguration : IEntityTypeConfiguration<UserCredential>
    {
        public void Configure(EntityTypeBuilder<UserCredential> builder)
        {
            builder.Property(x => x.InsertDate).IsRequired();
            builder.Property(x => x.UpdateDate).IsRequired(false);
            builder.Property(x => x.IsActive).IsRequired();

            builder.Property(x => x.Email).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(20);
            builder.Property(x => x.RoleId).IsRequired();
            
        }
    }
}
