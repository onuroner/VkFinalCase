using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkFinalCase.Base.Model
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime InsertDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        [DefaultValue(true)]
        public bool IsActive { get; set; }
    }
}
