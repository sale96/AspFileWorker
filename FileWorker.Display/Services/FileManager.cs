using System.Collections.Generic;
using Microsoft.AspNetCore.Hosting;

namespace FileWorker.Display.Services
{
    public class FileManager
    {
        private readonly IWebHostEnvironment _env;
        private List<File> Files;
        private int Id;

        private readonly List<(int Width, int Height)> imgSizes = new List<(int Width, int Height)>
        {
            (480, 270),
            (640, 360),
            (1280, 720),
            (1920, 1080)
        };

        public FileManager(IWebHostEnvironment env)
        {
            _env = env;
            Files = new List<File>();
        }
        
    }

    public class File
    {
        public int Id { get; set; }
        public int Width { get; set; }
        public string RelativePath { get; set; }
        public string GlobalPath { get; set; }
    }
}