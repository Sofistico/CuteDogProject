using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace CuteDogApi.Common
{
    [ApiController]
    [Route("api/[controller]")]
    public class ControllerBaseDog : ControllerBase
    {
        private ISender? _sender;

        protected ISender Bus => _sender ??= HttpContext.RequestServices.GetService<ISender>()!;
    }
}
