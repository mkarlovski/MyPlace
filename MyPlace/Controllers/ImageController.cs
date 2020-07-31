using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using MyPlace.Helper;
using MyPlace.Models;
using MyPlace.Services.Interfaces;
using MyPlace.ViewModel;

namespace MyPlace.Controllers
{
    public class ImageController : Controller
    {
        private readonly IImageService imageService;
        private readonly Microsoft.AspNetCore.Identity.UserManager<IdentityUser> userManager;

        public ImageController(IImageService imageService, Microsoft.AspNetCore.Identity.UserManager<IdentityUser> userManager)
        {
            this.imageService = imageService;
            
            this.userManager = userManager;
        }
        [Authorize]
        public async Task<IActionResult>  UserImages(string userId)
        {

            
            var userImages = await imageService.GetUserImages(userId);
            var toViewModel = userImages.Select(x => x.ToUserImageView()).ToList();
            return View(toViewModel);
        }

        public IActionResult Create()
        {
            var createImage = new CreateImageViewModel();
            return View(createImage);
        }

        [Authorize]
        [HttpPost]
        public IActionResult Create(CreateImageViewModel createImage)
        {
            
            if (ModelState.IsValid)
            {
                var image = new Image()
                {
                    ImageUrl = createImage.ImageUrl,
                    IsPrivate=createImage.IsPrivate,
                    UserId= createImage.UserId,
                    DateCreated=DateTime.Now,
                    
                };

                imageService.Add(image);
                return RedirectToAction(nameof(UserImages),new { userId=createImage.UserId });

            }
            return View(createImage);
        }


        public IActionResult EditImage(int imageId)
        {
            var image = imageService.GetImageById(imageId);
            var imageEditView = image.ToEditView();
            return View(imageEditView);
        }

        [HttpPost]
        public IActionResult EditImage(EditImageViewModel editImage)
        {
            if (ModelState.IsValid)
            {
                var image = editImage.ToImage();
                imageService.Update(image);
                return RedirectToAction(nameof(UserImages), new { userId = editImage.UserId });
            }

            return View(editImage);
        }


        public IActionResult DeleteImage(int imageId)
        {
            imageService.Delete(imageId);
            return RedirectToAction("Feed","Home");
        }
    }
}



//User.FindFirst(ClaimTypes.NameIdentifier).Value

