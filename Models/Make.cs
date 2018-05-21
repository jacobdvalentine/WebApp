using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace vega.Models
{
    public class Make
    {
        // Attributes for Make
        [Required]
        [StringLength(255)]
        public string Name{get; set;}
        public int Id{get; set;}
        public ICollection<Model> Models {get; set;}

        // Constuctor
        public Make()
        {
            Models = new Collection<Model>();
        }
    }
}