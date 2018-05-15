using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace vega.Model
{
    public class Make
    {
        // Attributes for Make
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