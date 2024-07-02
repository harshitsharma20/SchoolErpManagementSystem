using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StudentSubject
    {
        public int StudentRollNumber { get; set; }
        public StudentTable Student { get; set; }
        public int SubjectCode { get; set; }
        public SubjectTable Subject { get; set; }
        public int MarksScored {  get; set; }
        public int TotalMarks { get; set; }
    }
}
