using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer
{
    public interface IStudentSubjectService
    {
        public IList<StudentSubjectDTO> GetAll();
        public IList<StudentSubjectDTO> GetByStudentRollNumber(int rollnumber);
        public bool Create(StudentSubjectDTO studentsubject);
        public bool DeleteStudentSubject(int rollnumber, int subjectcode);
        public bool updateStudentSubject(int rollnumber, int subjectcode, StudentSubjectDTO studentsubject);
    }
}
