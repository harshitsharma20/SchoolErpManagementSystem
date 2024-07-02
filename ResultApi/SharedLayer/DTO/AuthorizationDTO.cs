using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer
{
    public class AuthorizationDTO
    {
        public string UserId { get; set; }
        public string Password { get; set; }
        public bool isAdmin {  get; set; }
        public bool isStudent {  get; set; }
    }
}
