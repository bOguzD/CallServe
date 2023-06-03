using CallServe.Core.Responses;
using Microsoft.AspNetCore.Mvc;

namespace CallServe.API.Controllers.Base
{
    [Route("api/[controller]")]
    [ApiController]
    //[ValidateFilterAttribute] Program.cs e ekledik
    public class BaseController : ControllerBase
    {
        [NonAction]//Swaggerda gözüküyor bunu yazmazsak. Kendi içimizde kullanıyoruz. bir endpoint değil
        public IActionResult CreateActionResult(ServiceResponse response)
        {
            if (response.StatusCode == 2004)
                return new ObjectResult(null)
                {
                    StatusCode = response.StatusCode
                };

            return new ObjectResult(response)
            {
                StatusCode = response.StatusCode
            };
        }
    }
}
