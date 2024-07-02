using BusinessAccessLayer;
using DataAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedLayer;

namespace ResultApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentSubjectController : ControllerBase
    {
        private readonly IStudentSubjectService _studentSubjectService;
        public StudentSubjectController(IStudentSubjectService studentSubjectService)
        {
            _studentSubjectService = studentSubjectService;
        }
        [HttpGet]
        [Route("GetAllStudentSubject")]
        public IList<StudentSubjectDTO> GetAll()
        {
            return _studentSubjectService.GetAll();
        }
        [HttpGet("GetStudentSubjectBy{rollnumber}")]
        public IList<StudentSubjectDTO> GetStudentSubject(int rollnumber)
        {
            return _studentSubjectService.GetByStudentRollNumber(rollnumber);
        }
        [HttpPost]
        [Route("CreateStudentSubject")]
        public bool Create(StudentSubjectDTO studentsubject)
        {
            return _studentSubjectService.Create(studentsubject);
        }
        [HttpDelete("DeleteStudentSubjectBy{rollnumber}&&{subjectcode}")]
        public bool DeleteStudentSubject(int rollnumber, int subjectcode)
        {
            return this._studentSubjectService.DeleteStudentSubject(rollnumber, subjectcode);
        }
        [HttpPut]
        [Route("UpdateStudentSubject")]
        public bool updateStudentSubject(int rollnumber, int subjectcode, StudentSubjectDTO studentsubject)
        {
            return _studentSubjectService.updateStudentSubject(rollnumber, subjectcode, studentsubject);
        }
    }
}
