using Bloggie.Data;
using Bloggie.Models.Domain;
using Bloggie.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bloggie.Controllers
{
    public class AdminTagsController : Controller
    {
        private BloggieDbContext db;
        public AdminTagsController(BloggieDbContext bloggieDbContext)
        {
            db = bloggieDbContext;
        }


        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddTagsRequest addTagsRequest)
        {

            var tag = new Tag
            {
                Name = addTagsRequest.Name,
                DisplayName = addTagsRequest.DisplayName,
            };

            db.Tags.Add(tag);
            db.SaveChanges();
                

            return RedirectToAction("List");
        }


        [HttpGet]
        public IActionResult List()
        {

            var tag = db.Tags.ToList();
            return View(tag);
        }
    }
}
