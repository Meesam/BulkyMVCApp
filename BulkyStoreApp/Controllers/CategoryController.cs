using BulkyStoreApp.Data;
using BulkyStoreApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace BulkyStoreApp.Controllers;

public class CategoryController : Controller
{
    private readonly ApplicationDbContext _dbContext;
    public CategoryController(ApplicationDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    
    public IActionResult Index()
    {
        List<Category> categories = _dbContext.Categories.ToList();
        return View(categories);
    }

    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(Category category)
    {
        if (ModelState.IsValid)
        {
            _dbContext.Categories.Add(category);
            _dbContext.SaveChanges();
            return RedirectToAction("Index");
        }
        return View();
    }
}