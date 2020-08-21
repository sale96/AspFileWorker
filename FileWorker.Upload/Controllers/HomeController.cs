using System.Collections.Generic;
using System.IO;
using FileWorker.Upload.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FileWorker.Upload.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment _env;
        private string _dir;

        public HomeController(IWebHostEnvironment env)
        {
            _env = env;
            _dir = _env.ContentRootPath;
        }

        public IActionResult Index() => View();

        [HttpPost]
        public IActionResult SingleFile(IFormFile file)
        {
            using (var fileStream = new FileStream(Path.Combine(_dir, file.FileName), FileMode.Create, FileAccess.Write))
            {
                file.CopyTo(fileStream);
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult MultipleFiles(IEnumerable<IFormFile> files)
        {
            foreach (var file in files)
            {
                using(var fileStream = new FileStream(Path.Combine(_dir, file.FileName), FileMode.Create, FileAccess.Write))
                {
                    file.CopyTo(fileStream);
                }
            }

            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult FileInModel(FormModel model)
        {
            using (FileStream fileStream = new FileStream(Path.Combine(_dir, $"{model.Name}.png"), FileMode.Create, FileAccess.Write))
            {
                model.File.CopyTo(fileStream);
            }
            
            return RedirectToAction("Index");
        }
    }
}
