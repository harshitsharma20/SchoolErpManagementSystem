using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TeacherDetails
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public int TeacherId { get; set; }
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
        [Required]
        public bool isAdmin {  get; set; }
        public ICollection<ResultTable> ResultTables { get; set; }

        //public IList<ResultTable> Marks { get; set; }
    }
}
