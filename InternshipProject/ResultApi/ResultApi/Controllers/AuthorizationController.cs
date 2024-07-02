using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedLayer;

namespace ResultApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorizationController : ControllerBase
    {
        private readonly IAuthorizationService _authorizationService;
        public AuthorizationController(IAuthorizationService authorizationService)
        {
            this._authorizationService = authorizationService;
        }

        [HttpGet]
        [Route("GetAuthorization")]
        public bool IsAuthorized(string username, string password)
        {
            return _authorizationService.IsAuthorized(username, password);
        }
    }
}
