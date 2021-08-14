using Microsoft.AspNetCore.Mvc;
using SportsStoreEntity.Models;
using SportsStoreEntity.Models.Pages;

namespace SportsStore.Controllers
{
    public class CategoriesController : Controller
    {
        private ICategoryRepository repository;

        public CategoriesController(ICategoryRepository repo) => repository = repo;

        public IActionResult Index(QueryOptions options) => View(repository.GetCategories(options));

        [HttpPost]
        public IActionResult AddCategory(Category category)
        {
            repository.AddCategory(category);
            return RedirectToAction(nameof(Index));
        }

        public IActionResult EditCategory(long id, QueryOptions options)
        {
            ViewBag.EditId = id;
            return View("Index", repository.GetCategories(options));
        }

        [HttpPost]
        public IActionResult UpdateCategory(Category category)
        {
            repository.UpdateCategory(category);
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        public IActionResult DeleteCategory(Category category)
        {
            repository.DeleteCategory(category);
            return RedirectToAction(nameof(Index));
        }
    }
}
