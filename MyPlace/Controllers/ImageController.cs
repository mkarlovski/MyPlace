using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyPlace.Models;
using MyPlace.Services.Interfaces;

namespace MyPlace.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService imageService;
        private readonly Microsoft.AspNetCore.Identity.UserManager<User> userManager;
        

        public ImageController(IImageService imageService, Microsoft.AspNetCore.Identity.UserManager<User> userManager)
        {
            this.imageService = imageService;
            this.userManager = userManager;
        }
        [Authorize]
        public async Task<IActionResult> UserImages()
        {

            var user = await userManager.GetUserAsync(User);
            var imagesDb = imageService.GetAll();
            return View();
        }
    }
}



//User.FindFirst(ClaimTypes.NameIdentifier).Value

