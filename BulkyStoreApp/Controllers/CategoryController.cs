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
    
    // GET
    public IActionResult Index()
    {
        List<Category> categories = _dbContext.Categories.ToList();
        return View(categories);
    }
}