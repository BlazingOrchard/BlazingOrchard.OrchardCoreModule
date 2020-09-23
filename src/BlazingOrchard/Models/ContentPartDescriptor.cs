using System.Collections.Generic;

namespace BlazingOrchard.Models
{
    public class ContentPartDescriptor
    {
        public string Name { get; set; }
        public ICollection<ContentPartFieldDescriptor> Fields { get; set; }
    }
}