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
    public class TeacherController : ControllerBase
    {
        private readonly ITeacherService _teacherService;
        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }

        [HttpGet]
        [Route("GetAllTeacher")]
        public IList<TeacherDTO> GetAllTeacher()
        {
            return _teacherService.GetAllTeacher();
        }

        [HttpGet("GetTeacherBy{id}")]
        public ActionResult<TeacherDTO> GetTeacher(int id)
        {
            var teacher = _teacherService.GetTeacher(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return teacher;
        }
        [HttpGet("GetById{id}")]
        public ActionResult<TeacherDTO> GetTeacherById(int id)
        {
            var teacher = _teacherService.GetTeacherById(id);
            if (teacher == null)
            {
                return NotFound();
            }
            return teacher;
        }

        [HttpPost]
        [Route("CreateTeacher")]
        public bool CreateTeacher(TeacherDTO teacher)
        {
            if (teacher == null)
            {
                return false;
            }
            return _teacherService.CreateTeacher(teacher);
        }
        [HttpDelete("DeleteTeacherBy{id}")]
        public ActionResult<bool> DeleteTeacher(int id)
        {
            if (id == 0)
            {
                return BadRequest();
            }
            return _teacherService.DeleteTeacher(id);
            
        }
        [HttpDelete]
        [Route("DeleteAllTeacher")]
        public bool DeleteAll()
        {
            return _teacherService.DeleteAll();
        }
        [HttpPut]
        [Route("UpdateTeacher")]
        public bool Updateteacher(int teacherId, TeacherDTO teacher)
        {
            return _teacherService.Updateteacher(teacherId, teacher);
        }
        [HttpGet]
        [Route("isAuthorized")]
        public TeacherDTO isAuthorized(string username, string password)
        {
            return this._teacherService.isAuthorized(username, password);
        }
    }
}