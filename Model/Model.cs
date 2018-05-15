namespace vega.Model
{
    public class Model
    {
        // Attributes for Model
        public string Name{get; set;}
        public int Id{get; set;}

        // Assocation a Model with Make properties
        public Make Make {get; set;}
        // Framework knows Make and MakeId refer to the same thing 
        public int MakeId {get; set;}
    }
}