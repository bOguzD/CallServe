using CallServe.API.Controllers.Base;
using CallServe.Core.Responses;
using CallServe.Service.Services.EntityServices.Contracts;
using Microsoft.AspNetCore.Mvc;

namespace CallServe.API.Controllers
{
    public class ProductController : BaseController
    {
        private readonly IProductService _service;
        
        public ProductController(IProductService service)
        {
            this._service = service;
        }

        [HttpGet]
        public async Task<ServiceResponse> Get()
        {
            var response = new ServiceResponse();
            try
            {
                response.Data = await _service.GetAllAsync();
            }
            catch (Exception ex)
            {
                response.Errors = new List<string> { ex.Message };
                response.IsSuccess = false;
            }
            return response;
        }
    }
}
