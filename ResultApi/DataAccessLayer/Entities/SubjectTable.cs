using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class SubjectTable
    {
        [Key] public int Id { get; set; }
        public string SubjectCode { get; set; }
        public string Name { get; set; }
        public ICollection<StudentSubject> StudentSubjects { get; set; }
        public int standard { get; set; }
    }
}
