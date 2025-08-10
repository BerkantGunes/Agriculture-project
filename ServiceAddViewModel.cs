using System.ComponentModel.DataAnnotations;

namespace Agriculture.Models
{
    public class ServiceAddViewModel
    {
        [Display(Name ="Title")]
        [Required(ErrorMessage ="Title cannot be null!")]
        public string Title { get; set; }

        [Display(Name = "Description")]
        [Required(ErrorMessage = "Description cannot be null!")]
        public string Description { get; set; }

        [Display(Name = "Image")]
        [Required(ErrorMessage = "Image cannot be null!")]
        public string Image { get; set; }
    }
}
