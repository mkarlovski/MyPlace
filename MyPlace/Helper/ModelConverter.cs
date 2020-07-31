using MyPlace.Models;
using MyPlace.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.Helper
{
    public static class ModelConverter
    {
        public static UserImageViewModel ToUserImageView(this Image image)
        {
            return new UserImageViewModel 
            { 
                Id=image.Id,
                ImageUrl=image.ImageUrl,
                DatePosted=image.DateCreated,
                IsPrivate=image.IsPrivate

            };
        }

        public static EditImageViewModel ToEditView(this Image image)
        {
            return new EditImageViewModel 
            {
                Id=image.Id,
                ImageUrl=image.ImageUrl,
                IsPrivate=image.IsPrivate
            };
        }

        public static Image ToImage(this EditImageViewModel editImage)
        {
            return new Image
            {
                Id=editImage.Id,
                ImageUrl=editImage.ImageUrl,
                IsPrivate=editImage.IsPrivate,
                UserId=editImage.UserId,
                DateCreated=editImage.DateCreated,
                
                
            };
        }

    }
}
