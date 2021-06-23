﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using CodeTheWay.Web.Ui.Models;

namespace CodeTheWay.Web.Ui.Repositories
{
    public class ShippingContainerRepository : IShippingContainerRepository
    {
        private AppDbContext AppDbContext;
        public ShippingContainerRepository(AppDbContext dbContext)
        {
            this.AppDbContext = dbContext;
        }
        public async Task<ShippingContainer> Create(ShippingContainer shippingContainer)
        {
            var result = await this.AppDbContext.Students.AddAsync(shippingContainer);
            await this.AppDbContext.SaveChangesAsync();
            return result.Entity;
        }


        public async Task<List<ShippingContainer>> GetShippingContainer()
        {
            return await this.AppDbContext.ShippingContainer.ToListAsync();
        }

        public async Task<ShippingContainer> GetShippingContainer(Guid id)
        {
            return await AppDbContext.ShippingContainer.FirstOrDefaultAsync(i => i.Id == id);
        }
        public async Task<ShippingContainer> Update(ShippingContainer model)
        {
            var result = AppDbContext.ShippingContainer.Update(model);
            await AppDbContext.SaveChangesAsync();
            return result.Entity;
        }
        public async Task<ShippingContainer> Delete(ShippingContainer model)
        {
            AppDbContext.ShippingContainer.Remove(model);
            await AppDbContext.SaveChangesAsync();
            return model;
        }
    }
}
