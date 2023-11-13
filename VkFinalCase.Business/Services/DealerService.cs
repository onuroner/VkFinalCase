using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VkFinalCase.Base;
using VkFinalCase.Base.Repositories;
using VkFinalCase.Base.Services;
using VkFinalCase.Base.UnitOfWorks;

namespace VkFinalCase.Business.Services
{
    public class DealerService : Service<Dealer>, IDealerService
    {
        private readonly IDealerRepository _dealerRepository;

        public DealerService(IGenericRepository<Dealer> repository, IUnitOfWork unitOfWork, IDealerRepository dealerRepository) : base(repository, unitOfWork)
        {
            _dealerRepository = dealerRepository;
        }

        public Task GetSingleCategoryWithProductsAsync(int categoryId)
        {
            throw new NotImplementedException();
        }
    }
}
