using System.ComponentModel.DataAnnotations;

namespace ImageCompressor.Web.Models;

public class UploadViewModel
{
    [Required]
    [Display(Name = "Select Images")]
    public IFormFile[] Images { get; set; }
}
