using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace MovieBlog.Models
{
    public class Post
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Title required")]
        [DisplayName("Naslov")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Post text required")]
        [DisplayName("Sadržaj")]
        public string Body { get; set; }

        [DataType(DataType.Date)]
        public DateTimeOffset PubDate { get; set; } = DateTimeOffset.Now;

        [DisplayName("Slika posta")]

        public string PostImg { get; set; }

        [DisplayName("Slika posta")]
        [Required(ErrorMessage = "Slika je potrebna")]
        [NotMapped]
        public IFormFile PostImgFile { get; set; }
    }
}
