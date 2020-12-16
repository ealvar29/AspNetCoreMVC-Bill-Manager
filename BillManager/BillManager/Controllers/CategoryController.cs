using BillManager.Data;
using BillManager.Models;
using BillManager.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BillManager.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _db;

        public CategoryController(ApplicationDbContext db)
        {
            _db = db;
        }
        
        // GET
        public IActionResult Index()
        {
            CategoryViewModel categoryViewModel = new CategoryViewModel
            {
                Categories = _db.Categories
            };
            return View(categoryViewModel);
            
        }
        //GET Create View
        public IActionResult Create()
        {
            return View();
        }
        
        //Post - Create Method for Categories
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Category category)
        {
            if (ModelState.IsValid)
            {
                _db.Categories.Add(category);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(category);
        }
    }
}