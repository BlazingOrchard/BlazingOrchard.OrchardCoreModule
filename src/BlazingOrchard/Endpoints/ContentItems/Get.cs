using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using OrchardCore;
using OrchardCore.ContentManagement;

namespace BlazingOrchard.Endpoints.ContentItems
{
    [Route("api/content-items/by-handle/{handle}")]
    public class Get : ControllerBase
    {
        private readonly IOrchardHelper _orchardHelper;

        public Get(IOrchardHelper orchardHelper) =>
            _orchardHelper = orchardHelper;

        [HttpGet]
        public async Task<ActionResult<ContentItem>> Handle(string handle)
        {
            var contentItem = await _orchardHelper.GetContentItemByHandleAsync(handle);

            if (contentItem == null)
                return NotFound();

            return contentItem;
        }
    }
}