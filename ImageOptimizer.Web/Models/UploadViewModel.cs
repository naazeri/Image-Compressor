using System.ComponentModel.DataAnnotations;

namespace ImageOptimizer.Web.Models;

public class UploadViewModel
{
    [Required]
    [Display(Name = "Select Images")]
    public IFormFile[] Images { get; set; }
}
