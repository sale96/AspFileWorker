using Microsoft.AspNetCore.Http;

namespace FileWorker.Upload.Models
{
    public class FormModel
    {
        public string Name { get; set; }
        public IFormFile File { get; set; }
    }
}