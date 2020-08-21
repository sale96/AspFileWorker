using FileWorker.Display.Services;
using Microsoft.AspNetCore.Mvc;

namespace FileWorker.Display.Controllers
{
    public class HomeController : Controller
    {
        private readonly FileManager _fileManager;
        public HomeController(FileManager fileManager)
        {
            _fileManager = fileManager;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
