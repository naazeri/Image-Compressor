using ImageCompressor.Service.Services;
using ImageCompressor.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace ImageCompressor.Web.Controllers;

public class HomeController(IImageCompressorService imageCompressorService) : Controller
{
    #region Properties

    private readonly string _uploadPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "uploads");

    #endregion

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Index(UploadViewModel model)
    {
        if (model.Images != null && model.Images.Length > 0)
        {
            var tasks = new List<Task>();

            // Use Parallel.ForEach to process images in parallel
            Parallel.ForEach(model.Images, (file) =>
                {
                    // Compress images concurrently in memory
                    using var memoryStream = new MemoryStream();
                    file.CopyTo(memoryStream);
                    var fileBytes = memoryStream.ToArray();
                    tasks.Add(imageCompressorService.CompressAsync(fileBytes, 1680, 400));
                });

            // Wait for all tasks to complete
            await Task.WhenAll(tasks);

            // Show success message
            ViewBag.Message = "Images have been compressed. Please check the 'wwwroot/images' directory.";
        }

        return View("Index", model);
    }
}
