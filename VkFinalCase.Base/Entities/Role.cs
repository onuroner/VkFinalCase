using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkFinalCase.Base.Model;

namespace VkFinalCase.Base
{
    [Table("Role", Schema = "dbo")]
    public class Role:BaseEntity
    {
        public string RoleName { get; set; }
    }
}
