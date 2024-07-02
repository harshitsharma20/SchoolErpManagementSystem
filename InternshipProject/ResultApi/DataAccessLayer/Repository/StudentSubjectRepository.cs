using AutoMapper;
using SharedLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class StudentSubjectRepository:IStudentSubjectRepository
    {
        private readonly ProjectDbContext _context;
        private readonly IMapper _mapper;
        public StudentSubjectRepository(ProjectDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool Create(StudentSubjectDTO studentsubject)
        {
            if (_context.StudentSubjects.Where(x => x.StudentRollNumber == studentsubject.StudentRollNumber && x.SubjectCode == studentsubject.SubjectCode).Any())
            {
                return false;
            }
            _context.StudentSubjects.Add(_mapper.Map<StudentSubject>(studentsubject));
            _context.SaveChanges();
            return true;
        }

        public bool DeleteStudentSubject(int rollnumber, int subjectcode)
        {
            var studentsubject = _context.StudentSubjects.Where(x => x.StudentRollNumber == rollnumber && x.SubjectCode==subjectcode).FirstOrDefault();
            if (studentsubject != null)
            {
                _context.StudentSubjects.Remove(studentsubject);
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public IList<StudentSubjectDTO> GetAll()
        {
            return _mapper.Map<IList<StudentSubjectDTO>>(_context.StudentSubjects);
        }

        public IList<StudentSubjectDTO> GetByStudentRollNumber(int rollnumber)
        {
            return _mapper.Map<IList<StudentSubjectDTO>>(_context.StudentSubjects.Where(x => x.StudentRollNumber == rollnumber));
        }

        public bool updateStudentSubject(int rollnumber, int subjectcode, StudentSubjectDTO studentsubject)
        {
            if (_context.StudentSubjects.Where(x => x.StudentRollNumber == studentsubject.StudentRollNumber && x.SubjectCode == studentsubject.SubjectCode).Any())
            {
                return false;
            }
            var newStudentSubject = _context.StudentSubjects.Where(x => x.StudentRollNumber == rollnumber && x.SubjectCode == subjectcode).FirstOrDefault();
            if (newStudentSubject != null)
            {
                newStudentSubject.MarksScored = studentsubject.MarksScored;
                newStudentSubject.TotalMarks = studentsubject.TotalMarks;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
    }
}
