using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;

namespace FileWorker.Upload.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _env;

        public HomeController()
        {
            
        }

        public IActionResult Index() => View();
    }
}
