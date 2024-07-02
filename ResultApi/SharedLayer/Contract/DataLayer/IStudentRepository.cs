using SharedLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer
{
    public interface IStudentRepository
    {
        public IList<StudentDTO> GetAllStudent();
        public StudentDTO GetStudent(int rollnumber);
        public StudentDTO GetStudentById(int id);
        public bool CreateStudent(StudentDTO student);
        public bool DeleteStudent(int rollnumber);
        public bool DeleteAll();
        public bool UpdateStudent(int rollnumber,StudentDTO student);
        public StudentDTO isAuthorized(string username, string password);
        public IList<StudentDTO> GetByStandard(int standard);

    }
}
