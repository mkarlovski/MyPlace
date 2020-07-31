using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.ViewModel
{
    public class EditImageViewModel
    {
        public int Id { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        
        public DateTime DateCreated { get; set; }
        [Required]
        public bool IsPrivate { get; set; }

        public string UserId { get; set; }
    }
}
