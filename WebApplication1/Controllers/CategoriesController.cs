using Microsoft.AspNetCore.Mvc;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    public class CategoriesController : Controller
    {
        ApplicationDbContext context = new ApplicationDbContext();
        public ViewResult Index()
        {
            var catagories = context.Category.ToList();
            return View("Index", catagories);

        }
        public ViewResult Details(int id)
        {
            var catagories = context.Category.Find(id);
            return View("Details", catagories);

        }
    }
}
