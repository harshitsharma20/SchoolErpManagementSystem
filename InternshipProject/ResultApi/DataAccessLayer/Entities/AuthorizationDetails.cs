using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class AuthorizationDetails
    {
        [Key] public int Id { get; set; }
        public string UserId { get; set; }
        public string Password { get; set; }
        public bool isAdmin {  get; set; }
        public bool isStudent {  get; set; }
    }
}
