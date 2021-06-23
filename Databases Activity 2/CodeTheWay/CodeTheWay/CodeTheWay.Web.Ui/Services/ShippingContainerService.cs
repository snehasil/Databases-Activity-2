using CodeTheWay.Web.Ui.Models;
using CodeTheWay.Web.Ui.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTheWay.Web.Ui.Services
{
    public class ShippingContainerService : IShippingContainerService
    {
        private IShippingContainerRepository ShippingContainerRepository;

        public ShippingContainerService(AppDbContext dbContext)
        {
            this.ShippingContainerRepository = new ShippingContainerRepository(dbContext);
        }
        public async Task<ShippingContainer> Create(ShippingContainer shippingContainer)
        {
            return await this.ShippingContainerRepository.Create(shippingContainer);
        }

        public async Task<List<ShippingContainer>> GetContainers()
        {
            return await this.ShippingContainerRepository.GetContainers();
        }
        public async Task<ShippingContainer> GetContainer(Guid id)
        {
            return await this.ShippingContainerRepository.GetContainer(id);
        }
        public async Task<ShippingContainer> Update(ShippingContainer shippingContainer)
        {
            return await ShippingContainerRepository.Update(shippingContainer);
        }
        public async Task<ShippingContainer> Delete(ShippingContainer shippingContainer)
        {
            return await ShippingContainerRepository.Delete(shippingContainer);
        }
    }
}
