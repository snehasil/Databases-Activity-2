﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeTheWay.Web.Ui.Services;
namespace CodeTheWay.Web.Ui.Controllers
{
    public class ShippingContainerController : Controller
    {
        private IShippingContainerService ShippingContainerService;

        public ShippingContainerController(IShippingContainerService shippingContainerService)
        {
            this.ShippingContainerService = shippingContainerService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
