﻿using LocalizationGlobalization.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace LocalizationGlobalization.Controllers
{
    public class HomeController : Controller
    {
        private readonly IHtmlLocalizer<HomeController> localizer;
        private readonly ILogger<HomeController> logger;

        public HomeController(ILogger<HomeController> logger, IHtmlLocalizer<HomeController> localizer)
        {
            this.logger = logger;
            this.localizer = localizer;
        }

        public IActionResult Index()
        {
            var test = localizer["HelloWorld"];
            ViewData["HelloWorld"] = test;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
