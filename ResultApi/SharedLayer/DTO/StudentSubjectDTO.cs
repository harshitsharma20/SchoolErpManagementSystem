using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer
{
    public class StudentSubjectDTO
    {
        public int StudentRollNumber { get; set; }
        public int SubjectCode { get; set; }
        public int MarksScored { get; set; }
        public int TotalMarks {  get; set; }
    }
}
