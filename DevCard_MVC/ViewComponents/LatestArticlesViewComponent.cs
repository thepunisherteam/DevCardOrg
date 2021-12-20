using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = new List<Article>
            {
                new Article(1,"آموزش asp.net core mvc","کاملترین پکیج آموزشی asp.net core mvc","blog-post-thumb-card-1.jpg"),
                new Article(1,"آموزش git & github","کاملترین پکیج آموزشی git & github","blog-post-thumb-card-2.jpg"),
                new Article(1,"آموزش license","کاملترین پکیج آموزشی license","blog-post-thumb-card-3.jpg"),
                new Article(1,"آموزش Js","کاملترین پکیج آموزشی Js","blog-post-thumb-card-4.jpg"),
            };
            return View("_LatestArticles",articles);
        }
    }
}
