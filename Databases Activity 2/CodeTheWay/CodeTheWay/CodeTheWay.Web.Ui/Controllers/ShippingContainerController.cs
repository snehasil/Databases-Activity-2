using CodeTheWay.Web.Ui.Models.ViewModels;
using CodeTheWay.Web.Ui.Models;
using CodeTheWay.Web.Ui.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeTheWay.Web.Ui.Controllers
{
    public class ShippingContainerController : Controller
    {
        private IShippingContainerService ShippingContainerService;
        public ShippingContainerController(IShippingContainerService shippingContainerService)
        {
            this.ShippingContainerService = shippingContainerService;
        }
        public async Task<IActionResult> Index()
        {
            return View(await ShippingContainerService.GetContainers());
        }
        public async Task<IActionResult> Create()
        {
            return View(new ShippingContainerRegisterViewModel());
        }
        [HttpPost]
        public async Task<IActionResult> Register(ShippingContainerRegisterViewModel model)
        {
            
                if (ModelState.IsValid)
                {
                    ShippingContainer shippingContainer = new ShippingContainer()
                    {
                        Id = model.Id,
                        Weight = model.Weight,
                        Destination = model.Destination
                    };
                    var result = await ShippingContainerService.Create(shippingContainer);
                    return RedirectToAction("Index"); ;
                }
            

            return RedirectToAction("Index");
        }

    }
}
