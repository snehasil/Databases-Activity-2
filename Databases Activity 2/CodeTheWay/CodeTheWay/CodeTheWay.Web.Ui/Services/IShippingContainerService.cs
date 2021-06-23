﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTheWay.Web.Ui.Models;

namespace CodeTheWay.Web.Ui.Services
{
    public interface IShippingContainerService
    {
        public Task<ShippingContainer> Create(ShippingContainer shippingContainer);

        public Task<List<ShippingContainer>> GetShippingContainer();
        public Task<ShippingContainer> GetShippingContainer(Guid id);
        public Task<ShippingContainer> Update(ShippingContainer shippingContainer);

        public Task<ShippingContainer> Delete(ShippingContainer shippingContainer);
    }
}
