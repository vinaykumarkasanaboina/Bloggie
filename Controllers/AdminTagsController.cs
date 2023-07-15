using Bloggie.Web.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace Bloggie.Controllers
{
    public class AdminTagsController : Controller
    {
        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Add(AddTagsRequest addTagsRequest)
        {
            var name = addTagsRequest.Name;
            var displayname = addTagsRequest.DisplayName;

            return View("Add");
        }
    }
}
