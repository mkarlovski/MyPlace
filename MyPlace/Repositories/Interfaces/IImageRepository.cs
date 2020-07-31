using Microsoft.AspNetCore.Identity;
using MyPlace.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.Repositories.Interfaces
{
    public interface IImageRepository
    {
        List<Image> GetAll();
        List<Image> GetUserImages(string user);
        void Add(Image image);
        Image GetImageById(int imageId);
        void Update(Image image);
        void Delete(int imageId);
    }
}
