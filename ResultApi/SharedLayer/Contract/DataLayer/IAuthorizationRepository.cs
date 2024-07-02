using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer
{
    public interface IAuthorizationRepository
    {
        public bool IsAuthorized(string userId, string password);
    }
}
