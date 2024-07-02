using SharedLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class StudentSubjectService:IStudentSubjectService
    {
        private readonly IStudentSubjectRepository _studentSubjectRepository;
        public StudentSubjectService(IStudentSubjectRepository studentSubjectRepository)
        {
            _studentSubjectRepository = studentSubjectRepository;
        }

        public bool Create(StudentSubjectDTO studentsubject)
        {
            return _studentSubjectRepository.Create(studentsubject);
        }

        public bool DeleteStudentSubject(int rollnumber, int subjectcode)
        {
            return _studentSubjectRepository.DeleteStudentSubject(rollnumber, subjectcode);
        }

        public IList<StudentSubjectDTO> GetAll()
        {
            return _studentSubjectRepository.GetAll();
        }

        public IList<StudentSubjectDTO> GetByStudentRollNumber(int rollnumber)
        {
            return _studentSubjectRepository.GetByStudentRollNumber(rollnumber);
        }

        public bool updateStudentSubject(int rollnumber, int subjectcode, StudentSubjectDTO studentsubject)
        {
            return _studentSubjectRepository.updateStudentSubject(rollnumber, subjectcode, studentsubject);
        }
    }
}
