namespace Lands.Domain
{
    using System.ComponentModel.DataAnnotations;

    public class Team
    {
        [Key]
        public int TeamId { get; set; }

        [Required(ErrorMessage = "The field {0} is requiered.")]
        [MaxLength(50, ErrorMessage = "The field {0} only can contains a maximum of {1} characters lenght.")]
        public string Name { get; set; }

        [Display(Name = "Image")]
        public string ImagePath { get; set; }
    }
}
