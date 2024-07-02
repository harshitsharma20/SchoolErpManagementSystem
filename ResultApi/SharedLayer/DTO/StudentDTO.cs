using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer
{
    public class StudentDTO
    {
        public int Id { get; set; }
        public int RollNumber{get;set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Standard {  get; set; }
        public string PhoneNumber {  get; set; }
        public string Email { get; set; }
        public string userName { get; set; }
        public string password { get; set; }
    }
}
