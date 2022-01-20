using ASP_Task_2.Models;
using ASP_Task_2.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Task_2.Controllers
{
    public class HomeController:Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            #region Data Transfer
            //List<Slider> sliders = new List<Slider>
            //{
            //    new Slider
            //    {
            //        Id = 1,
            //        Image = "slide-2.jpg",
            //        Title = "Lorem",
            //        KeyWord = "Ipsum Dolor",
            //        Desc = "Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. Similique ea voluptatem. Esse doloremque accusamus repellendus deleniti vel. Minus et tempore modi architecto.",
            //        RedirectUrl = "https://www.google.com",
            //        Order = 2
            //    },
            //    new Slider
            //    {
            //        Id = 2,
            //        Image = "slide-1.jpg",
            //        Title = "Welcome to",
            //        KeyWord = "Eterna",
            //        Desc = "Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem",
            //        RedirectUrl = "https://www.shazam.com",
            //        Order = 1
            //    },
            //    new Slider
            //    {
            //        Id = 3,
            //        Image = "slide-3.jpg",
            //        Title = "Sequi ea",
            //        KeyWord = "Dime Lara",
            //        Desc = "Ut velit est quam dolor ad a aliquid qui aliquid. Sequi ea ut et est quaerat sequi nihil ut aliquam. Occaecati alias dolorem mollitia ut. okay",
            //        RedirectUrl = "",
            //        Order = 3
            //    },
            //};

            //List<Feature> features = new List<Feature>
            //{
            //    new Feature
            //    {
            //        Id = 1,
            //        Icon = "<i class='bi bi-card-checklist'></i>",
            //        Title = "Lorem Ipsum",
            //        Desc ="Voluptatum deleniti atque corrupti quos dolores et quas molestias excepturi sint occaecati cupiditate non provident"

            //    },
            //    new Feature
            //    {
            //        Id = 2,
            //        Icon = "<i class='bi bi-bar-chart'></i>",
            //        Title = "Dolar Sitema",
            //        Desc ="Minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat tarad limino ata"

            //    },
            //    new Feature
            //    {
            //        Id = 3,
            //        Icon = "<i class='bi bi-binoculars'></i>",
            //        Title = "Sed ut perspiciatis",
            //        Desc ="Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur"

            //    }
            //};

            //HomeVM model = new HomeVM
            //{
            //    Sliders = sliders.OrderBy(s=>s.Order).ToList(),
            //    Features = features
            //};
            #endregion

            //List<Slider> sliders = _context.Sliders.ToList();

            //return View(sliders);

            HomeVM model = new HomeVM
            {
                Sliders = _context.Sliders.ToList(),
                Features = _context.Features.ToList()
            };

            return View(model);
        }
    }
}
