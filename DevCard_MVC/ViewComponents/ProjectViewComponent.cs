using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard_MVC.ViewComponents
{


    public class ProjectViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var projects = new List<Project>()
            {
                new Project(1,"تاکسی"," درخواست آنلاین تاکسی برای سفر های درون شهری","project-1.jpg","projectsoftware"),
                new Project(2,"حسابداری","حسابداری اسدی برای کار های روز مره","project-2.jpg","projectsoftware"),
                new Project(3,"مدارس","سیستم مدیریت مدارس","project-3.jpg","projectsoftware"),
                new Project(4,"زود فود"," درخواست آنلاین غذا برای سراسر کشور","project-4.jpg","projectsoftware"),

            };
            return View("_project", projects);
        }
    }
}
