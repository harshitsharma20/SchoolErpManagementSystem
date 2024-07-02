using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharedLayer
{
    public interface ITeacherRepository
    {
        public IList<TeacherDTO> GetAllTeacher();
        public TeacherDTO GetTeacher(int id);
        public TeacherDTO GetTeacherById(int id);
        public bool CreateTeacher(TeacherDTO teacher);
        public bool DeleteTeacher(int Id);
        public bool DeleteAll();
        public bool Updateteacher(int teacherId, TeacherDTO teacher);
        public TeacherDTO isAuthorized(string username, string password);
    }
}
