using ASPNETMVCCRUD.Data;
using Microsoft.AspNetCore.Mvc;

namespace ASPNETMVCCRUD.Controllers
{
    public class BooksController : Controller
    {
        private readonly MVCDemoDbContext appDbContext; //depandency injection

        public BooksController(MVCDemoDbContext appDbContext)
        {
            this.appDbContext = appDbContext;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
