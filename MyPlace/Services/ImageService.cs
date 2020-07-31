using Microsoft.AspNetCore.Identity;
using MyPlace.Models;
using MyPlace.Repositories.Interfaces;
using MyPlace.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.Services
{
    public class ImageService : IImageService
    {
        private readonly IImageRepository imageRepository;
        private readonly UserManager<IdentityUser> userManager;

        public ImageService(IImageRepository imageRepository, UserManager<IdentityUser> userManager)
        {
            this.imageRepository = imageRepository;
            this.userManager = userManager;
        }

        public void Add(Image image)
        {
            imageRepository.Add(image);
        }

        public void Delete(int imageId)
        {
            imageRepository.Delete(imageId);
        }

        public List<Image> GetAll()
        {
            return imageRepository.GetAll();
        }

        public Image GetImageById(int imageId)
        {
            return imageRepository.GetImageById(imageId);
        }

        public async Task<List<Image>> GetUserImages(string userId)
        {
            var currentUser =await userManager.FindByIdAsync(userId);
            var currentUserId = currentUser.Id;
            var userImages = imageRepository.GetUserImages(currentUserId);
            return userImages;
        }

        public void Update(Image image)
        {
            imageRepository.Update(image);
        }
    }
}
