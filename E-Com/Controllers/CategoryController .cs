using E_Com.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace E_Com.Controllers
{
    public class CategoryController : Controller
    {

        private readonly ILogger<CategoryController> _logger;

        private Application_dbcontext _dbContext = new Application_dbcontext();

        public CategoryController(ILogger<CategoryController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            List<Category> objCategoryList = _dbContext.Categories.ToList();
            return View(objCategoryList);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category obj)
        {
            _dbContext.Categories.Add(obj);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}