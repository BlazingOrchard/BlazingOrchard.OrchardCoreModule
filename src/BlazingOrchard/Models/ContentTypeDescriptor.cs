using System.Collections.Generic;

namespace BlazingOrchard.Models
{
    public class ContentTypeDescriptor
    {
        public string Name { get; set; }
        public ICollection<ContentTypePartDescriptor> Parts { get; set; }
    }
}