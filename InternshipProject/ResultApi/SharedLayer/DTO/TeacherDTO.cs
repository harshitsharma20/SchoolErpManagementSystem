using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer
{
    public class TeacherDTO
    {
        public int Id { get; set; }
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Standard { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string userName {  get; set; }
        public string password { get; set; }
        public bool isAdmin { get; set; }
    }
}
