using AutoMapper;
using Microsoft.IdentityModel.Tokens;
using SharedLayer;

namespace DataAccessLayer
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ProjectDbContext _context;
        private readonly IMapper _mapper;
        public StudentRepository(ProjectDbContext context,IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }
        public IList<StudentDTO> GetAllStudent()
        {
            return _mapper.Map<IList<StudentDTO>>(_context.Students);
        }

        public StudentDTO GetStudent(int rollnumber)
        {
            var student = _context.Students.Where(x => x.RollNumber == rollnumber).FirstOrDefault();
            return _mapper.Map<StudentDTO>(student);
        }
        public StudentDTO GetStudentById(int id)
        {
            var student = _context.Students.Where(x => x.Id == id).FirstOrDefault();
            return _mapper.Map<StudentDTO>(student);
        }
        public bool CreateStudent(StudentDTO student)
        {
            //student.Id = Guid.NewGuid();
            if(_context.Students.Where(x=>x.RollNumber == student.RollNumber).Any())
            {
                return false;
            }
            StudentTable newStudent = _mapper.Map<StudentTable>(student);
            _context.Students.Add(newStudent);
            _context.SaveChanges();
            return true;
        }
        public bool DeleteStudent(int id)
        {
            var student = _context.Students.Where(x => x.Id == id).FirstOrDefault();
            if(student != null)
            {
                _context.Students.Remove(student);
                _context.SaveChanges();
                return true;
            }
            return false;
        }
        public bool DeleteAll()
        {
            if (_context.Students.IsNullOrEmpty())
            {
                return false;
            }
            foreach(var student in _context.Students)
            {
                _context.Students.Remove(student);
            }
            _context.SaveChanges();
            return true;
        }
        public bool UpdateStudent(int rollnumber,StudentDTO student)
        {
            if(_context.Students.Where(x=>x.RollNumber==student.RollNumber).Any() && rollnumber!=student.RollNumber)
            {
                return false;
            }
            var newStudent = _context.Students.Where(x => x.RollNumber == rollnumber).FirstOrDefault();
            if(newStudent != null)
            {
                newStudent.FirstName = student.FirstName;
                newStudent.LastName = student.LastName;
                newStudent.RollNumber = student.RollNumber;
                newStudent.Standard = student.Standard;
                newStudent.PhoneNumber = student.PhoneNumber;
                newStudent.Email = student.Email;
                newStudent.userName = student.userName; 
                newStudent.password=student.password;
                _context.SaveChanges();
                return true;
            }
            return false;
        }

        public StudentDTO isAuthorized(string username, string password)
        {
            var student = _context.Students.Where(x => x.userName == username && x.password == password).FirstOrDefault();
            return _mapper.Map<StudentDTO>(student);
        }
        public IList<StudentDTO> GetByStandard(int standard)
        {
            return _mapper.Map<IList<StudentDTO>>(_context.Students.Where(x => x.Standard == standard));
        }
    }
}
