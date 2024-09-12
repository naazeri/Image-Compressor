using SixLabors.ImageSharp;
using SixLabors.ImageSharp.Formats.Webp;
using SixLabors.ImageSharp.Processing;

namespace ImageOptimizer.Service.Services;

public class ImageOptimizerService : IImageOptimizerService
{
    private readonly string optimizedImageDirectory = "images";

    public async Task<(string maxPath, string largePath, string thumbnailPath)> CompressAsync(byte[] imageBytes, int largeWidth, int thumbnailWidth)
    {
        using var image = Image.Load(imageBytes);
        var maxPath = await SaveImage(image, 75, image.Width, "max");
        var largePath = await SaveImage(image, 75, largeWidth, "large");
        var thumbnailPath = await SaveImage(image, 50, thumbnailWidth, "thumbnail");

        return (maxPath, largePath, thumbnailPath);
    }

    public async Task<(string maxPath, string largePath, string thumbnailPath)> CompressAsync(string uploadPath, int largeWidth, int thumbnailWidth)
    {
        using var image = await Image.LoadAsync(uploadPath);
        var maxPath = await SaveImage(image, 75, image.Width, "max");
        var largePath = await SaveImage(image, 75, largeWidth, "large");
        var thumbnailPath = await SaveImage(image, 50, thumbnailWidth, "thumbnail");

        return (maxPath, largePath, thumbnailPath);
    }

    private async Task<string> SaveImage(Image image, int quality, int width, string subDirName)
    {
        if (width > 0 && image.Width > width)
        {
            var maxWidth = image.Width;
            var maxHeight = image.Height;
            image.Mutate(i => i.Resize(width, width / maxWidth * maxHeight));
        }

        var now = DateTime.Now;
        var viewPath = Path.Combine(optimizedImageDirectory, now.Year.ToString(), now.Month.ToString(), subDirName);
        var path = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", viewPath);
        var imageName = $"{Guid.NewGuid().ToString()}.webp";

        if (!Directory.Exists(path)) Directory.CreateDirectory(path);

        await image.SaveAsWebpAsync(Path.Combine(path, imageName), new WebpEncoder { Quality = quality });
        return $"/{viewPath.Replace("\\", "/")}/{imageName}";
    }

}
