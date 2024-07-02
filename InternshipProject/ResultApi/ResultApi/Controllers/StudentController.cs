using BusinessAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SharedLayer;
using System.Globalization;

namespace ResultApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        /// <summary>
        /// loggingcreation to be done
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("GetAllStudent")]
        public IList<StudentDTO> GetAllStudent()
        {
            return _studentService.GetAllStudent();
        }

        [HttpGet("GetStudentBy{rollnumber}")]
        public ActionResult<StudentDTO> GetStudent(int rollnumber)
        {
            var student = _studentService.GetStudent(rollnumber);
            if (student == null)
            {
                return NotFound();
            }
            return student;
        }
        [HttpGet("GetById{id}")]
        public ActionResult<StudentDTO> GetStudentById(int id)
        {
            var student = _studentService.GetStudentById(id);
            if (student == null)
            {
                return NotFound();
            }
            return student;
        }

        [HttpPost]
        [Route("CreateStudent")]
        public bool CreateStudent(StudentDTO student)
        {
            if (student == null)
            {
                return false;
            }
            return _studentService.CreateStudent(student);
        }
        [HttpDelete("DeleteStudentBy{id}")]
        public ActionResult<bool> DeleteStudent(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            return _studentService.DeleteStudent(id);
        }
        [HttpDelete]
        [Route("DeleteAllStudent")]
        public bool DeleteAll()
        {
            return _studentService.DeleteAll();
        }
        [HttpPut]
        [Route("UpdateStudent")]
        public bool updateStudent(int rollnumber,StudentDTO student)
        {
            return _studentService.UpdateStudent(rollnumber,student);
        }
        [HttpGet]
        [Route("isAuthorized")]
        public StudentDTO isAuthorized(string username,string password)
        {
            return this._studentService.isAuthorized(username,password);
        }
        [HttpGet]
        [Route("GetByStandard{standard}")]
        public IList<StudentDTO> GetByStandard(int standard)
        {
            return _studentService.GetByStandard(standard);
        }
    }
}
