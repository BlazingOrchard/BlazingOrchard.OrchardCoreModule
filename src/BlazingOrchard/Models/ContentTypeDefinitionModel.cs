using System.Collections.Generic;

namespace BlazingOrchard.Models
{
    public class ContentTypeDefinitionModel : ContentDefinitionModel
    {
        public ICollection<ContentTypePartDefinitionModel> Parts { get; set; } = default!;
    }
}