using System.ComponentModel.DataAnnotations;

namespace vega.Models
{
    public class Feature
    {
        // Attributes for Model
        [Required]
        [StringLength(255)]
        public string Name{get; set;}
        public int Id{get; set;}

    }
}