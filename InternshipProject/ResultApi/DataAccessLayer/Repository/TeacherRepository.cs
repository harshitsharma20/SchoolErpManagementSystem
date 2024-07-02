using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using SharedLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly ProjectDbContext _context;
        private readonly IMapper _mapper;
        public TeacherRepository(ProjectDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IList<TeacherDTO> GetAllTeacher()
        {
            return _mapper.Map<IList<TeacherDTO>>(_context.Teachers);
        }

        public TeacherDTO GetTeacher(int teacherId)
        {
            var teacher = _context.Teachers.Where(x => x.TeacherId == teacherId).FirstOrDefault();
            return _mapper.Map<TeacherDTO>(teacher);
        }
        public TeacherDTO GetTeacherById(int id)
        {
            var teacher = _context.Teachers.Where(x => x.Id == id).FirstOrDefault();
            return _mapper.Map<TeacherDTO>(teacher);
        }

        public bool CreateTeacher(TeacherDTO teacher)
        {
            if (_context.Teachers.Where(x => x.TeacherId == teacher.TeacherId).Any())
            {
                return false;
            }
            TeacherDetails newTeacher = _mapper.Map<TeacherDetails>(teacher);
            _context.Teachers.Add(newTeacher);
            _context.SaveChanges();
            return true;
        }
        public bool DeleteTeacher(int Id)
        {
            var teacher = _context.Teachers.Where(x => x.Id == Id).FirstOrDefault();
            if (teacher != null)
            {
                _context.Teachers.Remove(teacher);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool DeleteAll()
        {
            if (_context.Teachers.IsNullOrEmpty())
            {
                return false;
            }
            foreach(var teacher in _context.Teachers)
            {
                _context.Teachers.Remove(teacher);
            }
            _context.SaveChanges();
            return true;
        }
        public bool Updateteacher(int teacherId, TeacherDTO teacher)
        {
            if (_context.Teachers.Where(x => x.TeacherId == teacher.TeacherId).Any() && teacherId!=teacher.TeacherId)
            {
                return false;
            }
            var newTeacher = _context.Teachers.Where(x => x.TeacherId == teacherId).FirstOrDefault();
            if (newTeacher != null)
            {
                newTeacher.FirstName = teacher.FirstName;
                newTeacher.LastName = teacher.LastName;
                newTeacher.TeacherId = teacher.TeacherId;
                newTeacher.Standard = teacher.Standard;
                newTeacher.PhoneNumber = teacher.PhoneNumber;
                newTeacher.Email = teacher.Email;
                newTeacher.userName = teacher.userName;
                newTeacher.password= teacher.password;
                newTeacher.isAdmin = teacher.isAdmin;
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public TeacherDTO isAuthorized(string username, string password)
        {
            var teacher = _context.Teachers.Where(x => x.userName == username && x.password == password).FirstOrDefault();
            return _mapper.Map<TeacherDTO>(teacher);
        }
    }
}
