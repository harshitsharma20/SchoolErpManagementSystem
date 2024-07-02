using BusinessAccessLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SharedLayer;

namespace ResultApi
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectServices _subjectServices;
        public SubjectController(ISubjectServices subjectServices)
        {
            _subjectServices = subjectServices;
        }
        [HttpGet]
        [Route("GetAllSubject")]
        public IList<SubjectDTO> GetAll()
        {
            return _subjectServices.GetAll();
        }
        [HttpGet("GetSubjectBy{subjectCode}")]
        public ActionResult<SubjectDTO> GetById(string subjectCode)
        {
            var subject = _subjectServices.GetById(subjectCode);
            if(subject==null)
            {
                return NotFound();
            }
            return subject;
        }
        [HttpPost]
        [Route("CreateSubject")]
        public bool Create(SubjectDTO subject)
        {
            return _subjectServices.Create(subject);
        }
        [HttpDelete("DeleteSubjectBy{id}")]
        public bool DeleteSubject(int id)
        {
            if (id == 0)
            {
                return false;
            }
            return _subjectServices.DeleteSubject(id);
        }
        [HttpDelete]
        [Route("DeleteAllSubject")]
        public bool DeleteAll()
        {
            return _subjectServices.DeleteAll();
        }
        [HttpPut]
        [Route("UpdateSubject")]
        public bool Updateteacher(string subjectCode, SubjectDTO subject)
        {
            return _subjectServices.updateSubject(subjectCode, subject);
        }
        [HttpGet]
        [Route("GetByStandard{standard}")]
        public IList<SubjectDTO> GetByStandard(int standard)
        {
            return _subjectServices.GetByStandard(standard);
        }
    }
}
