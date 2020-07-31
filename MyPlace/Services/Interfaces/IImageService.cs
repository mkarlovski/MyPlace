using MyPlace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.Services.Interfaces
{
    public interface IImageService
    {
        List<Image> GetAll();
        Task<List<Image>> GetUserImages(string userId);
        void Add(Image image);
        Image GetImageById(int imageId);
        void Update(Image image);
        void Delete(int imageId);
    }
}
