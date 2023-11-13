using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkFinalCase.Base.UnitOfWorks
{
    public interface IUnitOfWork
    {
        void Complete();
        Task CompleteAsync();
        public void CompleteTransaction();
    }
}
