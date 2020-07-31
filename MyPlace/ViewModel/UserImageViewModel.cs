using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.ViewModel
{
    public class UserImageViewModel
    {
        public int Id { get; set; }
        [Required]
        public string ImageUrl { get; set; }
        [Required]
        public DateTime DatePosted { get; set; }
        [Required]
        public bool IsPrivate { get; set; }

    }
}
