using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Models
{
    public class Article
    {
        public long id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }

        public Article(long id, string title, string description, string image)
        {
            this.id = id;
            Title = title;
            Description = description;
            Image = image;
        }
    }
}
