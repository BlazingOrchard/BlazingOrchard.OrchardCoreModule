namespace BlazingOrchard.Models
{
    public class ContentPartFieldDescriptor
    {
        public string Name { get; set; }
        public ContentFieldDescriptor Field { get; set; }
        public ContentPartFieldSettings Settings { get; set; }
    }
}