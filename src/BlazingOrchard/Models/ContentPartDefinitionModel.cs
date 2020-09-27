using System.Collections.Generic;

namespace BlazingOrchard.Models
{
    public class ContentPartDefinitionModel : ContentDefinitionModel
    {
        public ICollection<ContentPartFieldDefinitionModel> Fields { get; set; } = default!;
    }
}