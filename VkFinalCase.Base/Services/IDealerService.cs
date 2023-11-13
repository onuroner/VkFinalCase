using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VkFinalCase.Base.Services
{
    public interface IDealerService: IService<Dealer>
    {
        public Task GetSingleCategoryWithProductsAsync(int categoryId);
    }
}
