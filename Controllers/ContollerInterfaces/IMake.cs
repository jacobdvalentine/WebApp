using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace vega.Controllers.ContollerInterfaces
{
    public class IMake
    {
        public string Name{get; set;}
        public int Id{get; set;}
        public ICollection<IModel> Models {get; set;}

        // Constuctor
        public IMake()
        {
            Models = new Collection<IModel>();
        }
    }
}