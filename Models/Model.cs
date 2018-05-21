using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace vega.Models
{
    [Table("Models")]
    public class Model
    {
        // Attributes for Model
        [Required]
        [StringLength(255)]
        public string Name{get; set;}
        public int Id{get; set;}

        // Assocation a Model with Make properties
        public Make Make {get; set;}
        // Framework knows Make and MakeId refer to the same thing 
        public int MakeId {get; set;}
    }
}