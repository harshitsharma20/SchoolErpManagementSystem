using DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using SharedLayer;


namespace BusinessAccessLayer
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public IList<StudentDTO> GetAllStudent()
        {
            return _studentRepository.GetAllStudent();
        }
        public StudentDTO GetStudent(int rollnumber)
        {
            return _studentRepository.GetStudent(rollnumber);
        }
        public StudentDTO GetStudentById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }
        public bool CreateStudent(StudentDTO student)
        {
            return _studentRepository.CreateStudent(student);
        }
        public bool DeleteStudent(int rollnumber)//bool
        {
            return _studentRepository.DeleteStudent(rollnumber);
        }
        public bool DeleteAll()
        {
            return _studentRepository.DeleteAll();
        }
        public bool UpdateStudent(int rollnumber,StudentDTO student)
        {
            return _studentRepository.UpdateStudent(rollnumber,student);
        }

        public StudentDTO isAuthorized(string username, string password)
        {
            return _studentRepository.isAuthorized(username, password);
        }
        public IList<StudentDTO> GetByStandard(int standard)
        {
            return _studentRepository.GetByStandard(standard);
        }
    }
}
