using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StudentTable
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int RollNumber { get; set; }
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }
        [Required]
        public int Standard { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string userName { get; set; }
        [Required]
        public string password { get; set; }
        public ICollection<StudentSubject> StudentSubjects { get; set; }
        public ResultTable? ResultTable { get; set; }
        //public virtual MarksTable? Marks { get; set; }//? this shows nullable
    }
}
