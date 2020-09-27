using System.Linq;
using BlazingOrchard.Models;
using Microsoft.AspNetCore.Mvc;
using OrchardCore.ContentManagement.Metadata;
using OrchardCore.ContentManagement.Metadata.Models;

namespace BlazingOrchard.Endpoints.ContentTypes
{
    [Route("api/content-types/{contentType}")]
    public class Get : ControllerBase
    {
        private readonly IContentDefinitionManager _contentDefinitionManager;

        public Get(IContentDefinitionManager contentDefinitionManager) =>
            _contentDefinitionManager = contentDefinitionManager;

        [HttpGet]
        public ActionResult<ContentTypeDescriptor> Handle(string contentType)
        {
            var contentTypeDefinition = _contentDefinitionManager.GetTypeDefinition(contentType);

            if (contentTypeDefinition == null)
                return NotFound();

            return Map(contentTypeDefinition);
        }

        private static ContentTypeDescriptor Map(ContentTypeDefinition source) =>
            new ContentTypeDescriptor
            {
                Name = source.Name,
                Parts = source.Parts.Select(Map).ToList()
            };

        private static ContentTypePartDescriptor Map(ContentTypePartDefinition source) =>
            new ContentTypePartDescriptor
            {
                Name = source.Name,
                Part = new ContentPartDescriptor
                {
                    Name = source.PartDefinition.Name,
                    Fields = source.PartDefinition.Fields.Select(Map).ToList()
                },
                Settings = source.GetSettings<ContentTypePartSettings>()
            };

        private static ContentPartFieldDescriptor Map(ContentPartFieldDefinition source) =>
            new ContentPartFieldDescriptor
            {
                Name = source.Name,
                Field = new ContentFieldDescriptor
                {
                    Name = source.FieldDefinition.Name
                },
                Settings = source.GetSettings<ContentPartFieldSettings>()
            };
    }
}