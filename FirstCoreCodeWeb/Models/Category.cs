using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FirstCoreCodeWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [NotMapped]
        public string EncryptedId { get; set; }

        [Required]
        public string Name { get; set; }

        [Display(Name="Display Order")]
        [Range(1, 100, ErrorMessage ="Display Order must be between 1 to 100 only!!")]
        public int DisplayOrder { get; set; }

        public DateTime CreatedDateTime { get; set; } = DateTime.Now;
    }
}
