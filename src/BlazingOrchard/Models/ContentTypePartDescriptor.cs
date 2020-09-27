namespace BlazingOrchard.Models
{
    public class ContentTypePartDescriptor
    {
        public string Name { get; set; }
        public ContentPartDescriptor Part { get; set; }
        public ContentTypePartSettings Settings { get; set; }
    }
}