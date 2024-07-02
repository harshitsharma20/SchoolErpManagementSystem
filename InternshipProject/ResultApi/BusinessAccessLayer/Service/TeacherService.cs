using SharedLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessAccessLayer
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _teacherRepository;
        public TeacherService(ITeacherRepository teacherRepository)
        {
            _teacherRepository = teacherRepository;
        }
        public IList<TeacherDTO> GetAllTeacher()
        {
            return _teacherRepository.GetAllTeacher();
        }
        public TeacherDTO GetTeacher(int id)
        {
            return _teacherRepository.GetTeacher(id);
        }
        public TeacherDTO GetTeacherById(int id)
        {
            return _teacherRepository.GetTeacherById(id);
        }
        public bool CreateTeacher(TeacherDTO teacher)
        {
            return _teacherRepository.CreateTeacher(teacher);
        }
        public bool DeleteTeacher(int Id)
        {
            return _teacherRepository.DeleteTeacher(Id);
        }
        public bool DeleteAll()
        {
            return _teacherRepository.DeleteAll();
        }
        public bool Updateteacher(int teacherId, TeacherDTO teacher)
        {
            return _teacherRepository.Updateteacher(teacherId, teacher);
        }
        public TeacherDTO isAuthorized(string username, string password)
        {
            return _teacherRepository.isAuthorized(username, password);
        }
    }
}
