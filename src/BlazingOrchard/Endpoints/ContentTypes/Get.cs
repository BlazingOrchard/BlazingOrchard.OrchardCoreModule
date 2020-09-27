using System.Linq;
using BlazingOrchard.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;
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
        public ActionResult<ContentTypeDefinitionModel> Handle(string contentType)
        {
            var contentTypeDefinition = _contentDefinitionManager.GetTypeDefinition(contentType);

            if (contentTypeDefinition == null)
                return NotFound();

            return Map(contentTypeDefinition);
        }

        private static ContentTypeDefinitionModel Map(ContentTypeDefinition source) =>
            new ContentTypeDefinitionModel
            {
                Name = source.Name,
                Parts = source.Parts.Select(Map).ToList()
            };

        private static ContentTypePartDefinitionModel Map(ContentTypePartDefinition source) =>
            new ContentTypePartDefinitionModel
            {
                Name = source.Name,
                Part = new ContentPartDefinitionModel
                {
                    Name = source.PartDefinition.Name,
                    Fields = source.PartDefinition.Fields.Select(Map).ToList()
                },
                Settings = new JObject(source.Settings)
            };

        private static ContentPartFieldDefinitionModel Map(ContentPartFieldDefinition source) =>
            new ContentPartFieldDefinitionModel
            {
                Name = source.Name,
                FieldDefinition = new ContentFieldDefinitionModel
                {
                    Name = source.FieldDefinition.Name
                },
                Settings = new JObject(source.Settings)
            };
    }
}