using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MyPlace.Data;
using MyPlace.Models;
using MyPlace.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly ApplicationDbContext context;

        public ImageRepository(ApplicationDbContext context)
        {
            this.context = context;
        }

        public void Add(Image image)
        {
            context.Images.Add(image);
            context.SaveChanges();
        }

        public void Delete(int imageId)
        {
            var image = new Image
            {
                Id = imageId
            };
            context.Images.Remove(image);
            context.SaveChanges();
        }

        public List<Image> GetAll()
        {
            return context.Images.Include(x=>x.User).ToList();
        }

        public Image GetImageById(int imageId)
        {
            return context.Images.FirstOrDefault(x => x.Id == imageId);
        }

        public List<Image> GetUserImages(string user)
        {
            return context.Images.Where(x => x.UserId == user).ToList();
        }

        public void Update(Image image)
        {
            context.Images.Update(image);
            context.SaveChanges();
        }
    }
}
