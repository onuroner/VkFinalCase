using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkFinalCase.Base.Repositories;
using VkFinalCase.Base;

namespace VkFinalCase.DataAccess.Repository
{
    public class DealerRepository : GenericRepository<Dealer>, IDealerRepository
    {
        public DealerRepository(VkDbContext context) : base(context)
        {
        }

        public async Task<Dealer> GetSingleCDealerWithUserCredentialAsync(Guid dealerId)
        {
            return await _context.Dealers.Include(c => c.User).Where(x => x.Id == dealerId).SingleOrDefaultAsync();
        }
    }
}
