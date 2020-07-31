using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyPlace.Helper;
using MyPlace.Models;
using MyPlace.Services.Interfaces;

namespace MyPlace.Controllers
{
    public class HomeController : Controller
    {
        private readonly UserManager<IdentityUser> userManager;

        public IImageService ImageService { get; }

        //private readonly UserManager<User> userManager;

        public HomeController(UserManager<IdentityUser> userManager, IImageService imageService )
        {
           
            this.userManager = userManager;
            ImageService = imageService;
        }
        public IActionResult Feed()
        {
            var imagesDb = ImageService.GetAll();
            var homeOverview = imagesDb.Select(x => x.ToHomeOverview()).ToList();

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
