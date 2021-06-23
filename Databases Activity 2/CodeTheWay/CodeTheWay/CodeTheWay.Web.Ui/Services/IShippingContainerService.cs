﻿using CodeTheWay.Web.Ui.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTheWay.Web.Ui.Services
{
    public interface IShippingContainerService
    {
        public Task<ShippingContainer> Create(ShippingContainer shippingContainer);

        public Task<List<ShippingContainer>> GetContainers();
        public Task<ShippingContainer> GetContainer(Guid id);
        public Task<ShippingContainer> Update(ShippingContainer shippingContainer);

        public Task<ShippingContainer> Delete(ShippingContainer shippingContainer);
    }
}
