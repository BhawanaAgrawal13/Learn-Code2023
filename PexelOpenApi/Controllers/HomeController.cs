using Microsoft.AspNetCore.Mvc;
using PexelOpenApi.Models;
using PexelOpenApi.Service;

namespace PexelOpenApi.Controllers
{
    public class HomeController : Controller
    {
        private readonly PexelsService _pexelsService;

        public HomeController(PexelsService pexelsService)
        {
            _pexelsService = pexelsService;
        }

        public IActionResult Index()
        {
            var model = new ImageSearchViewModel();
            return View(model);
        }

        [HttpPost]
        public IActionResult SearchImages(ImageSearchViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.SearchResults = _pexelsService.DisplaySearchImages(model.Search);
            }

            return View("Index", model);
        }

        public ActionResult RandomPhotos()
        {
            var photos = _pexelsService.GetRandomPhotos();
            return View(photos);
        }
    }
}