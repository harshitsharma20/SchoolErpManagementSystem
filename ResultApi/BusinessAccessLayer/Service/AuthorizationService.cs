using SharedLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class AuthorizationService : IAuthorizationService
    {
        private readonly IAuthorizationRepository _authorizationRepository;
        public AuthorizationService(IAuthorizationRepository authorizationRepository)
        {
            this._authorizationRepository = authorizationRepository;
        }
        public bool IsAuthorized(string userId, string password)
        {
            return _authorizationRepository.IsAuthorized(userId, password);
        }
    }
}
