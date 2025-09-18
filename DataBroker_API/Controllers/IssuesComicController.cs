using System.Net;
using DataBroker_API.Model;
using Microsoft.AspNetCore.Mvc;

namespace DataBroker_API.Controllers
{    
    [ApiController]    
    public class IssuesComicController : ControllerBase
    {
        protected RESTAPIResponse _response;

        public IssuesComicController() { 
            _response = new RESTAPIResponse();
        }

        [HttpGet]
        public async Task<ActionResult<RESTAPIResponse>> GetIssues()
        {            
            _response.StatusCode = HttpStatusCode.OK;

            try
            {
                return Ok(_response);
            }
            catch (Exception ex)
            {
                _response.IsSuccess = false;
                _response.ErrorMessage = new List<string> { ex.Message };
            }

            return _response;
        }
    }
}
