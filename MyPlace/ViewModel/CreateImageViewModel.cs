using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyPlace.ViewModel
{
    public class CreateImageViewModel
    {
        public string UserId { get; set; }
        public string ImageUrl { get; set; }
        public bool IsPrivate { get; set; }
    }
}
