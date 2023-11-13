using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkFinalCase.Base.Repositories
{
    public interface IDealerRepository : IGenericRepository<Dealer>
    {
        Task<Dealer> GetSingleCDealerWithUserCredentialAsync(Guid dealerId);
    }
}
